using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using VM.Assembler.Parser;

namespace VM.Assembler;

internal class ParseTreeVisitor : asmBaseVisitor<object>
{
    byte memIndex = 0;

    public readonly Dictionary<byte, object> Memory = new();

    public Dictionary<string, int> Labels { get; set; } = new();

    private readonly Dictionary<string, byte> Registers = new()
    {
        { "ra", 0b00000000 },
        { "rb", 0b00000001 },
        { "rc", 0b00000010 },
        { "rd", 0b00000011 },
        { "re", 0b00000100 },
        { "rf", 0b00000101 },
        { "rg", 0b00000110 },
        { "rh", 0b00000111 }
    };

    private readonly Dictionary<string, byte> Types = new()
    {
        { "r", 0b00000000 }, // register
        { "l", 0b00000001 }, // label
        { "m", 0b00000010 }, // memory
        { "n", 0b00000011 } // null
    };

    internal static readonly Dictionary<string, byte> OpCodes = new()
    {
        { "NOP", 0b00000000 },
        { "RET", 0b00000001 },
        { "HLT", 0b00000010 },
        { "ADD", 0b00000011 },
        { "SUB", 0b00000100 },
        { "MUL", 0b00000101 },
        { "DIV", 0b00000110 },
        { "SHL", 0b00000111 },
        { "SHR", 0b00001000 },
        { "JMP", 0b00001001 },
        { "BEQ", 0b00001010 },
        { "NOT", 0b00001011 },
        { "AND", 0b00001100 },
        { "OR",  0b00001101 },
        { "CEQ", 0b00001110 },
        { "CGT", 0b00001111 },
        { "CLT", 0b00010000 },
        { "XOR", 0b00010001 },
        { "STR", 0b00010010 },
        //{ "TBA", 0b00010011 },
        //{ "TBA", 0b00010100 },
        { "REM", 0b00010101 },
        //{ "TBA", 0b00010110 },
        { "CNV", 0b00010111 },
        { "SWP", 0b00011000 },
        { "CALL", 0b00011001 },
        { "RTC", 0b00011010 },
        { "DFC", 0b00011011 },
        { "INT", 0b00011100 },
    };

    internal static string GetOpCodeMnemonic(byte opCode)
    {
        foreach (var key in OpCodes.Keys)
        {
            if (OpCodes[key] == opCode)
                return key;
        }

        return "NOP";
    }

    private readonly StringBuilder _sb = new();

    public string Output
    {
        get => _sb.ToString();
    }

    private byte GetKey(object val)
    {
        foreach (var key in Memory.Keys)
        {
            if (Memory[key].Equals(val))
                return key;
        }

        return 0;
    }

    public override dynamic VisitCompilation_unit([NotNull] asmParser.Compilation_unitContext context)
    {
        foreach (var tree in context.include())
            Visit(tree);

        foreach (var tree in context.instruction())
            Visit(tree);

        return null;
    }

    public override dynamic VisitInclude([NotNull] asmParser.IncludeContext context)
    {

        return null;
    }

    public override object VisitOperand([NotNull] asmParser.OperandContext context)
    {
        if (context.integer() != null)
            Visit(context.integer());

        else if (context.floating_point_number() != null)
            Visit(context.floating_point_number());

        else if (context.String() != null)
        {
            _sb.Append(Convert.ToString(Types["m"], 2).PadLeft(8, '0') + " ");

            string s = context.String().GetText()[1..^1]
                .Replace("\\\\", "\\")
                .Replace("\\\"", "\"")
                .Replace("\\r", "\r")
                .Replace("\\n", "\n")
                .Replace("\\b", "\b");

            Memory.Add(memIndex, s);

            _sb.Append(Convert.ToString(memIndex, 2).PadLeft(8, '0') + " ");

            memIndex++;
        }

        else if (context.Identifier() != null)
        {
            if (Labels.TryGetValue(context.Identifier().GetText(), out int line))
            {
                _sb.Append(Convert.ToString(Types["l"], 2).PadLeft(8, '0') + " ");
                _sb.Append(Convert.ToString((byte)line, 2).PadLeft(8, '0') + " ");
            }
            else if (Registers.TryGetValue(context.Identifier().GetText(), out byte registerId))
            {
                _sb.Append(Convert.ToString(Types["r"], 2).PadLeft(8, '0') + " ");
                _sb.Append(Convert.ToString(registerId, 2).PadLeft(8, '0') + " ");
            }
            else
                Console.WriteLine($"Error on line {context.Start.Line}: Register or label '{context.Identifier().GetText()}' does not exist.");
        }

        else if (context.line_number() != null)
        {
            _sb.Append(Convert.ToString(Types["l"], 2).PadLeft(8, '0') + " ");

            string number = string.Join("", context.line_number().DecimalDigit().Select(d => d.GetText()));
            int value = Convert.ToInt32(number, 10);

            if (value > 254)
            {
                Console.WriteLine($"Error on line {context.line_number().Start.Line}: Reference to invalid line number {value}.");
                value = 254;
            }

            _sb.Append(Convert.ToString(value, 2).PadLeft(8, '0') + " ");
        }

        return null;
    }

    public override object VisitBinary_literal([NotNull] asmParser.Binary_literalContext context)
    {
        _sb.Append(Convert.ToString(Types["m"], 2).PadLeft(8, '0') + " ");

        string binary = string.Join("", context.BinaryDigit().Select(d => d.GetText()));
        int value = Convert.ToInt32(binary, 2);

        if (Memory.ContainsValue(value))
        {
            _sb.Append(Convert.ToString(GetKey(value), 2).PadLeft(8, '0') + " ");
            return null;
        }

        Memory.Add(memIndex, value);

        _sb.Append(Convert.ToString(memIndex, 2).PadLeft(8, '0') + " ");

        memIndex++;

        return null;
    }

    public override object VisitDecimal_literal([NotNull] asmParser.Decimal_literalContext context)
    {
        _sb.Append(Convert.ToString(Types["m"], 2).PadLeft(8, '0') + " ");

        string number = string.Join("", context.DecimalDigit().Select(d => d.GetText()));
        int value = Convert.ToInt32(number, 10);

        if (Memory.ContainsValue(value))
        {
            _sb.Append(Convert.ToString(GetKey(value), 2).PadLeft(8, '0') + " ");
            return null;
        }

        Memory.Add(memIndex, value);

        _sb.Append(Convert.ToString(memIndex, 2).PadLeft(8, '0') + " ");

        memIndex++;

        return null;
    }

    public override object VisitHex_literal([NotNull] asmParser.Hex_literalContext context)
    {
        _sb.Append(Convert.ToString(Types["m"], 2).PadLeft(8, '0') + " ");

        string number = string.Join("", context.HexDigit().Select(d => d.GetText()));
        int value = Convert.ToInt32(number, 16);

        if (Memory.ContainsValue(value))
        {
            _sb.Append(Convert.ToString(GetKey(value), 2).PadLeft(8, '0') + " ");
            return null;
        }

        Memory.Add(memIndex, value);

        _sb.Append(Convert.ToString(memIndex, 2).PadLeft(8, '0') + " ");

        memIndex++;

        return null;
    }

    public override object VisitBinary_float([NotNull] asmParser.Binary_floatContext context)
    {
        _sb.Append(Convert.ToString(Types["m"], 2).PadLeft(8, '0') + " ");

        string binary = context.BinaryDigit()[0].GetText();
        //binary += ".";
        binary += string.Join("", context.BinaryDigit().Select(d => d.GetText()));

        long v = 0;

        for (int i = binary.Length - 1; i >= 0; i--)
            v = (v << 1) + (binary[i] - '0');

        double value = BitConverter.ToDouble(BitConverter.GetBytes(v), 0);

        if (Memory.ContainsValue(value))
        {
            _sb.Append(Convert.ToString(GetKey(value), 2).PadLeft(8, '0') + " ");
            return null;
        }

        Memory.Add(memIndex, value);

        _sb.Append(Convert.ToString(memIndex, 2).PadLeft(8, '0') + " ");

        memIndex++;

        return null;
    }

    public override object VisitDecimal_float([NotNull] asmParser.Decimal_floatContext context)
    {
        _sb.Append(Convert.ToString(Types["m"], 2).PadLeft(8, '0') + " ");

        string number = context.DecimalDigit()[0].GetText();
        //number += ".";
        number += string.Join("", context.DecimalDigit().Select(d => d.GetText()));

        double value = Convert.ToDouble(Convert.ToInt64(number, 16), CultureInfo.InvariantCulture);

        if (Memory.ContainsValue(value))
        {
            _sb.Append(Convert.ToString(GetKey(value), 2).PadLeft(8, '0') + " ");
            return null;
        }

        Memory.Add(memIndex, value);

        _sb.Append(Convert.ToString(memIndex, 2).PadLeft(8, '0') + " ");

        memIndex++;

        return null;
    }

    public override object VisitHex_float([NotNull] asmParser.Hex_floatContext context)
    {
        _sb.Append(Convert.ToString(Types["m"], 2).PadLeft(8, '0') + " ");

        string number = context.HexDigit()[0].GetText();
        number += string.Join("", context.HexDigit().Select(d => d.GetText()));

        double value = Convert.ToDouble(Convert.ToInt64(number, 16), CultureInfo.InvariantCulture);

        if (Memory.ContainsValue(value))
        {
            _sb.Append(Convert.ToString(GetKey(value), 2).PadLeft(8, '0') + " ");
            return null;
        }

        Memory.Add(memIndex, value);

        _sb.Append(Convert.ToString(memIndex, 2).PadLeft(8, '0') + " ");

        memIndex++;

        return null;
    }

    public override object VisitInstruction([NotNull] asmParser.InstructionContext context)
    {
        _sb.Append(Convert.ToString(context.Start.Line, 2).PadLeft(8, '0') + " ");

        if (context.label() != null)
        {
            if (!Labels.ContainsKey(context.label().Identifier().GetText()))
                Labels.Add(context.label().Identifier().GetText(), context.Start.Line);

            if (context.Start.Line > 254)
                Console.WriteLine($"Error on line {context.Start.Line}: Source file cannot contain more than 254 lines of code. Consider splitting your code into multiple files.");   
        }

        _sb.Append(Convert.ToString(OpCodes[context.OpCode().GetText().ToUpper()], 2).PadLeft(8, '0') + " ");

        if (context.operand().Length == 0)
            _sb.Append("00000011 00000000 00000011 00000000 00000011 00000000 00000011 00000000 ");
        else if (context.operand().Length == 1)
        {
            Visit(context.operand()[0]);
            _sb.Append("00000011 00000000 00000011 00000000 00000011 00000000 ");
        }
        else if (context.operand().Length == 2)
        {
            foreach (var tree in context.operand())
                Visit(tree);

            _sb.Append("00000011 00000000 00000011 00000000 ");
        }
        else if (context.operand().Length == 3)
        {
            foreach (var tree in context.operand())
                Visit(tree);

            _sb.Append("00000011 00000000 ");
        }
        else if (context.operand().Length == 4)
        {
            foreach (var tree in context.operand())
                Visit(tree);
        }
        else
        {
            Console.WriteLine($"Warning on line {context.operand()[4].Start.Line}: Too many operands (expected at most 4). Last {(context.operand().Length - 4 == 1 ? "\b" : context.operand().Length - 4)} operand{(context.operand().Length - 4 == 1 ? "" : "s")} will be ignored.");

            foreach (var tree in context.operand().Take(4))
                Visit(tree);
        }

        _sb.Append(Environment.NewLine);

        return null;
    }
}