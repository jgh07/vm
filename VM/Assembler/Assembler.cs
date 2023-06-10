using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using VM.Assembler.Parser;

namespace VM.Assembler;

public static class Assembler
{
    public static string Disassemble(byte[] bytes)
    {
        StringBuilder sb = new();

        byte[][] instructions = bytes.Chunk(10).ToArray();

        List<byte> memoryBytes;
        Dictionary<byte, byte[]> memory = new();

        var memoryChunk = instructions.Where(ins => ins[0] == 255).First();
        memoryBytes = instructions[(instructions.ToList().IndexOf(memoryChunk))..].SelectMany(arr => arr).ToArray()[1..].ToList();

        while (memoryBytes.Count > 0)
        {
            byte index = memoryBytes[0];
            byte length = memoryBytes[1];
            byte[] data = memoryBytes.ToArray()[2..(length + 2)];
            memory.Add(index, data);

            memoryBytes.RemoveRange(0, length + 2);
        }

        for (int i = 0; i < instructions.Length; i++)
        {
            if (instructions[i][0] == 255) // Memory section
                break;

            sb.Append($"Line{instructions[i][0]}: "); // Label
            sb.Append($"{ParseTreeVisitor.GetOpCodeMnemonic(instructions[i][1])} "); // Opcode

            if (instructions[i].Length < 3)
                continue;

            byte[] operands = instructions[i][2..];
            byte[][] operandChunks = operands.Chunk(2).ToArray();

            List<byte[]> remainingOperands = operandChunks.Where(o => o[0] != 3).ToList();
            
            foreach (byte[] operand in operandChunks)
            {
                if (remainingOperands.Count > 0)
                    remainingOperands.Remove(remainingOperands.First());

                switch (operand[0])
                {
                    // Register
                    case 0:
                        sb.Append($"{operand[1] switch
                        {
                            0 => "ra",
                            1 => "rb",
                            2 => "rc",
                            3 => "rd",
                            4 => "re",
                            5 => "rf",
                            6 => "rg",
                            7 => "rh",
                            _ => $"; Invalid register.{Environment.NewLine}"
                        }}{(remainingOperands.Count > 0 ? "," : "")} ");

                        break;

                    // Label
                    case 1:
                        sb.Append($"Line{instructions[i][0]}{(remainingOperands.Count > 0 ? "," : "")} ");
                        break;

                    // Memory
                    case 2:
                        byte[] data = memory[operand[1]];

                        if (data.Length > 4)
                        {
                            string str = Encoding.UTF8.GetString(data)
                                .Replace("\b", "\\b")
                                .Replace("\"", "\\\"")
                                .Replace("\r", "\\r")
                                .Replace("\n", "\\n");

                            sb.Append($"\"{str}\"{(remainingOperands.Count > 0 ? "," : "")} ");
                            break;
                        }

                        byte[] paddedArray = new byte[4];

                        Buffer.BlockCopy(data, 0, paddedArray, 0, data.Length);
                        sb.Append($"{BitConverter.ToInt32(paddedArray)}{(remainingOperands.Count > 0 ? "," : "")} ");
                        break;

                    // Null
                    case 3: break;
                }
            }

            sb.AppendLine();
        }

        return sb.ToString();
    }

    public static void Compile(string source, string path)
    {
        source += Environment.NewLine;

        ICharStream charStream = CharStreams.fromString(source);
        ITokenSource lexer = new asmLexer(charStream);
        ITokenStream tokens = new CommonTokenStream(lexer);
        asmParser parser = new(tokens);

        IParseTree compilationUnit = parser.compilation_unit();

        var stdout = Console.Out;
        Console.SetOut(TextWriter.Null);

        ParseTreeVisitor labelResolver = new();
        labelResolver.Visit(compilationUnit);

        Console.SetOut(stdout);

        ParseTreeVisitor visitor = new()
        {
            Labels = labelResolver.Labels
        };

        visitor.Visit(compilationUnit);

        StringBuilder sb = new StringBuilder(visitor.Output)
            .AppendLine()
            .AppendLine("11111111"); // Memory section

        foreach (var item in visitor.Memory)
        {
            var sizeChunks = Convert.ToString(item.Key, 2).Chunk(8).Select(c => new string(c).PadLeft(8, '0')).ToList();

            sb.Append(string.Join(" ", sizeChunks))
                .Append(' ');

            if (item.Value is string)
            {
                byte[] bytes = Encoding.UTF8.GetBytes(item.Value as string);

                if (bytes.Length > 255)
                {
                    Console.WriteLine("Error: Unsupportedly large constant.");
                    bytes = bytes.Take(255).ToArray();
                }

                sb.Append(Convert.ToString(bytes.Length, 2).PadLeft(8, '0') + " ");

                foreach (byte b in bytes)
                    sb.Append(Convert.ToString(b, 2).PadLeft(8, '0') + " ");

                sb.AppendLine();
            }
            else if (item.Value is int i)
            {
                var chunks = Convert.ToString(i, 2).Chunk(8).Select(c => new string(c).PadLeft(8, '0'));

                if (chunks.Count() > 255)
                {
                    Console.WriteLine("Error: Unsupportedly large constant.");
                    chunks = chunks.Take(255);
                }

                sb.Append(Convert.ToString(chunks.Count(), 2).PadLeft(8, '0') + " ");

                sb.AppendLine(string.Join(" ", chunks));
            }
            else if (item.Value is double d)
            {
                var chunks = Convert.ToString(Convert.ToInt64(d), 2).Chunk(8).Select(c => new string(c).PadLeft(8, '0'));

                if (chunks.Count() > 255)
                {
                    Console.WriteLine("Error: Unsupportedly large constant.");
                    chunks = chunks.Take(255);
                }

                sb.Append(Convert.ToString(chunks.Count(), 2).PadLeft(8, '0') + " ");

                sb.AppendLine(string.Join(" ", chunks));
            }
        }

        File.WriteAllText(path, sb.ToString());
    }
}