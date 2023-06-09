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
    public static string Disassemble(string binary)
    {
        StringBuilder sb = new();

        binary = binary
            .Replace(" ", "")
            .Replace("\r", "")
            .Replace("\n", "");

        byte[] bytes = binary.Chunk(8).Select(c => Convert.ToByte(new string(c), 2)).ToArray();
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

            sb.Append($"_{instructions[i][0]}: "); // Label
            sb.Append($"{ParseTreeVisitor.GetOpCodeMnemonic(instructions[i][1])} "); // Opcode

            if (instructions[i].Length < 3)
                continue;

            byte[] operands = instructions[i][2..];
            byte[][] operandChunks = operands.Chunk(2).ToArray();

            List<byte[]> operandChunksList = operandChunks.ToList();

            for (int j = 0; j < operandChunksList.Count; j++)
            {
                try
                {
                    for (int k = 0; k < operandChunksList[j].Length; k++)
                    {
                        if (operandChunksList[j][k] == 3)
                            operandChunksList.RemoveAt(j);
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    break;
                }
            }
            
            foreach (byte[] operand in operandChunks)
            {
                if (operandChunksList.Count > 0)
                    operandChunksList.Remove(operandChunksList.Last());

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
                        }}{(operandChunksList.Count > 1 ? "," : "")} ");

                        break;

                    // Label
                    case 1:
                        sb.Append($"_{instructions[i][0]}{(operandChunksList.Count > 1 ? "," : "")} ");
                        break;

                    // Memory
                    case 2:
                        byte[] data = memory[operand[1]];

                        if (data.Length > 4)
                        {
                            sb.Append($"\"{Encoding.UTF8.GetString(data)}\"{(operandChunksList.Count > 1 ? "," : "")} ");
                            break;
                        }

                        byte[] paddedArray = new byte[4];

                        Buffer.BlockCopy(data, 0, paddedArray, 0, data.Length);
                        sb.Append($"{BitConverter.ToInt32(paddedArray)}{(operandChunksList.Count > 1 ? "," : "")} ");
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
        ParseTreeVisitor visitor = new();
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