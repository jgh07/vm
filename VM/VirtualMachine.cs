using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static VM.VirtualMachine.OpCode;

namespace VM;

internal class VirtualMachine
{
    public enum OpCode : byte
    {
        Nop = 0b00000000,
        Ret = 0b00000001,
        Hlt = 0b00000010,
        Add = 0b00000011,
        Sub = 0b00000100,
        Mul = 0b00000101,
        Div = 0b00000110,
        Shl = 0b00000111,
        Shr = 0b00001000,
        Jmp = 0b00001001,
        Beq = 0b00001010,
        Not = 0b00001011,
        And = 0b00001100,
        Or = 0b00001101,
        Ceq = 0b00001110,
        Cgt = 0b00001111,
        Clt = 0b00010000,
        Xor = 0b00010001,
        Str = 0b00010010,
        Rem = 0b00010101,
        Cnv = 0b00010111,
        Swp = 0b00011000,
        Call = 0b00011001,
        Rtc = 0b00011010,
        Dfc = 0b00011011,
        Int = 0b00011100
    }

    public object RA;
    public object RB;
    public object RC;
    public object RD;
    public object RE;
    public object RF;
    public object RG;
    public object RH;

    readonly byte[] bytes;
    readonly Dictionary<byte, byte[]> memory = new();
    readonly Dictionary<byte, byte[]> _instructions = new();

    public VirtualMachine(byte[] bytes)
    {
        this.bytes = bytes;
    }

    private int currentInstructionIndex;
    byte[][] instructions;

    public void Run()
    {
        try
        {
            instructions = bytes.Chunk(10).ToArray();

            List<byte> memoryBytes;

            var memoryChunk = instructions.Where(ins => ins[0] >= 239).First();
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

                _instructions.Add(instructions[i][0], instructions[i][1..]);
            }

            for (currentInstructionIndex = 0; currentInstructionIndex < instructions.Length; currentInstructionIndex++)
            {
                if (instructions[currentInstructionIndex][0] == 255)
                    break;

                ExecuteInstruction(instructions[currentInstructionIndex]);
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Error: Invalid executable.");
        }
    }

    private void VerifyRegister(OpCode op, int opCount, byte type)
    {
        if (type != 0)
        {
            Console.WriteLine($"Error: Instruction {op} requires register as operand {opCount}.");
            Environment.Exit(-1);
        }
    }

    private byte GetKey(object val)
    {
        foreach (var key in _instructions.Keys)
        {
            if (_instructions[key].Equals(val))
                return key;
        }

        return 0;
    }

    private void ExecuteInstruction(byte[] instruction)
    {
        byte label = instruction[0];
        byte opcode = instruction[1];

        byte t1 = instruction[2];
        byte o1 = instruction[3];

        byte t2 = instruction[4];
        byte o2 = instruction[5];

        byte t3 = instruction[6];
        byte o3 = instruction[7];

        byte t4 = instruction[8];
        byte o4 = instruction[9];

        switch ((OpCode)opcode)
        {
            case Nop: return;

            case Ret:
            case Hlt:
                Environment.Exit(0);
                return;

            case Add:

                VerifyRegister(Add, 1, t1);
                SetRegister(GetRegister(o1), (int)ResolveOperand(t1, o1) + (int)ResolveOperand(t2, o2));

                break;

            case Sub:

                VerifyRegister(Sub, 1, t1);
                SetRegister(GetRegister(o1), (int)ResolveOperand(t1, o1) - (int)ResolveOperand(t2, o2));

                break;

            case Mul:

                VerifyRegister(Mul, 1, t1);
                SetRegister(GetRegister(o1), (int)ResolveOperand(t1, o1) * (int)ResolveOperand(t2, o2));

                break;

            case Div:

                VerifyRegister(Div, 1, t1);
                SetRegister(GetRegister(o1), (int)ResolveOperand(t1, o1) / (int)ResolveOperand(t2, o2));

                break;

            case Shl:

                VerifyRegister(Shl, 1, t1);
                SetRegister(GetRegister(o1), (int)ResolveOperand(t1, o1) << (int)ResolveOperand(t2, o2));

                break;

            case Shr:

                VerifyRegister(Shr, 1, t1);
                SetRegister(GetRegister(o1), (int)ResolveOperand(t1, o1) >> (int)ResolveOperand(t2, o2));

                break;

            case Jmp:

                if (!instructions.Any(b => b[0] == o1))
                    break;

                currentInstructionIndex = Array.IndexOf(instructions, instructions.Where(b => b[0] == o1).First()) - 1; // decrement by one because for loop will increment it again

                break;

            case Beq:

                if ((int)ResolveOperand(t1, o1) != (int)ResolveOperand(t2, o2))
                    break;

                if (!instructions.Any(b => b[0] == o3))
                    break;

                currentInstructionIndex = Array.IndexOf(instructions, instructions.Where(b => b[0] == o3).First()) - 1;

                break;

            case Not:

                VerifyRegister(Not, 1, t1);
                SetRegister(GetRegister(o1), ~(int)ResolveOperand(t1, o1));

                break;

            case And:

                VerifyRegister(And, 1, t1);
                SetRegister(GetRegister(o1), (int)ResolveOperand(t1, o1) & (int)ResolveOperand(t2, o2));

                break;

            case Or:

                VerifyRegister(Or, 1, t1);
                SetRegister(GetRegister(o1), (int)ResolveOperand(t1, o1) | (int)ResolveOperand(t2, o2));

                break;

            case Ceq:

                VerifyRegister(Ceq, 1, t1);
                SetRegister(GetRegister(o1), (int)ResolveOperand(t1, o1) == (int)ResolveOperand(t2, o2) ? 1 : 0);

                break;

            case Cgt:

                VerifyRegister(Cgt, 1, t1);
                SetRegister(GetRegister(o1), (int)ResolveOperand(t1, o1) > (int)ResolveOperand(t2, o2) ? 1 : 0);

                break;

            case Clt:

                VerifyRegister(Clt, 1, t1);
                SetRegister(GetRegister(o1), (int)ResolveOperand(t1, o1) < (int)ResolveOperand(t2, o2) ? 1 : 0);

                break;

            case Xor:

                VerifyRegister(Xor, 1, t1);
                SetRegister(GetRegister(o1), (int)ResolveOperand(t1, o1) ^ (int)ResolveOperand(t2, o2));

                break;

            case Str:

                VerifyRegister(Str, 1, t1);
                SetRegister(GetRegister(o1), ResolveOperand(t2, o2, o3));

                break;

            case Rem:

                VerifyRegister(Rem, 1, t1);
                SetRegister(GetRegister(o1), (int)ResolveOperand(t1, o1) % (int)ResolveOperand(t2, o2));

                break;

            case Cnv:

                VerifyRegister(Cnv, 1, t1);

                break;

            case Swp:

                VerifyRegister(Swp, 1, t1);
                VerifyRegister(Swp, 2, t2);

                object temp = ResolveOperand(t1, o1);

                SetRegister(GetRegister(o1), GetRegisterData(GetRegister(o2)));
                SetRegister(GetRegister(o2), temp);

                break;

            case Call:
                break;

            case Rtc:
                break;

            case Dfc:
                break;

            case Int:

                if (RA is not int)
                    break;

                switch ((int)RA)
                {
                    case 1:
                        Console.Write(RB);
                        break;

                    case 2:
                        RB = Console.ReadLine();
                        break;

                    case 3:

                        if (int.TryParse(RB.ToString(), out int i))
                            RB = i;
                        else
                            RB = 0;

                        break;

                    case 4:

                        if (RB is not string)
                            RB = RB.ToString();

                        break;

                    default:
                        Console.WriteLine($"Error: Invalid interrupt {(int)RA}.");
                        break;
                }

                break;
        }
    }

    private void SetRegister(string register, object data)
    {
        switch (register)
        {
            case "RA":
                RA = data;
                break;
            case "RB":
                RB = data;
                break;
            case "RC":
                RC = data;
                break;
            case "RD":
                RD = data;
                break;
            case "RE":
                RE = data;
                break;
            case "RF":
                RF = data;
                break;
            case "RG":
                RG = data;
                break;
            default:
                RH = data;
                break;
        }
    }

    private object GetRegisterData(string register)
    {
        return register switch
        {
            "RA" => RA,
            "RB" => RB,
            "RC" => RC,
            "RD" => RD,
            "RE" => RE,
            "RF" => RF,
            "RG" => RG,
            _ => RH,
        };
    }

    private string GetRegister(byte data)
    {
        switch (data)
        {
            case 0:
                return "RA";
            case 1:
                return "RB";
            case 2:
                return "RC";
            case 3:
                return "RD";
            case 4:
                return "RE";
            case 5:
                return "RF";
            case 6:
                return "RG";
            case 7:
                return "RH";
            default:
                Console.WriteLine($"Error: Invalid register {data}.");
                return "RH";
        }
    }

    private object ResolveOperand(byte type, byte data, byte treatAsString = 0)
    {
        switch (type)
        {
            case 0: // Register

                switch (data)
                {
                    case 0:
                        return RA;
                    case 1:
                        return RB;
                    case 2:
                        return RC;
                    case 3:
                        return RD;
                    case 4:
                        return RE;
                    case 5:
                        return RF;
                    case 6:
                        return RG;
                    case 7:
                        return RH;
                    default:
                        Console.WriteLine($"Error: Invalid register {data}.");
                        return RH;
                }

            case 1: // Label
                return _instructions[data];

            case 2: // Memory
                byte[] dt = memory[data];

                if (dt.Length > 4 || treatAsString > 0)
                    return Encoding.UTF8.GetString(dt);

                byte[] paddedArray = new byte[4];

                Buffer.BlockCopy(dt, 0, paddedArray, 0, dt.Length);
                return BitConverter.ToInt32(paddedArray);

            case 3: // Null
                return 0;

            default:
                Console.WriteLine($"Error: Invalid type {type}.");
                return 0;
        }
    }
}