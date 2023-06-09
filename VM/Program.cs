using System;
using System.IO;
using System.Linq;
using VM;
using VM.Assembler;

return args switch
{
    ["compile", ..] => Compile(args),
    ["disassemble", ..] => Disassemble(args),
    ["run", ..] => Run(args),
    ["help"] or [] => ShowHelpMessage(),
    _ => DisplayError()
};

static int Compile(string[] args)
{
    string inFile;
    string outFile;
    bool compact = false;

    if (args.Any(a => a == "-compact"))
    {
        compact = true;
        args = args.Where(a => a != "-compact").ToArray();
    }

    if (args.Length == 1)
    {
        Console.WriteLine("Error: No source file specified.");
        return -1;
    }

    if (args.Length == 2)
    {
        inFile = args[1];
        outFile = Path.ChangeExtension(inFile, "bin");
    }
    else
    {
        inFile = args[1];
        outFile = args[2];
    }

    if (!File.Exists(inFile))
    {
        Console.WriteLine($"Error: File {Path.GetFileName(inFile)} does not exist.");
        return -1;
    }

    Assembler.Compile(File.ReadAllText(inFile), outFile);

    if (compact)
    {
        string s = File.ReadAllText(outFile)
            .Replace(" ", "")
            .Replace("\r", "")
            .Replace("\n", "");

        File.WriteAllText(outFile, s);
    }

    return 0;
}

static int Disassemble(string[] args)
{
    string inFile;
    string outFile;

    if (args.Length == 1)
    {
        Console.WriteLine("Error: No executable file specified.");
        return -1;
    }

    if (args.Length == 2)
    {
        inFile = args[1];
        outFile = Path.ChangeExtension(inFile, "asm");
    }
    else
    {
        inFile = args[1];
        outFile = args[2];
    }

    if (!File.Exists(inFile))
    {
        Console.WriteLine($"Error: File {Path.GetFileName(inFile)} does not exist.");
        return -1;
    }

    File.WriteAllText(outFile, Assembler.Disassemble(File.ReadAllText(inFile)));

    return 0;
}

static int Run(string[] args)
{
    string inFile;

    if (args.Length == 1)
    {
        Console.WriteLine("Error: No executable file specified.");
        return -1;
    }

    inFile = args[1];

    if (Path.GetExtension(inFile) == ".asm")
    {
        Compile(args);
        inFile = Path.ChangeExtension(inFile, "bin");
    }

    if (!File.Exists(inFile))
    {
        Console.WriteLine($"Error: File {Path.GetFileName(inFile)} does not exist.");
        return -1;
    }

    string binary = File.ReadAllText(inFile)
        .Replace(" ", "")
        .Replace("\r", "")
        .Replace("\n", "");

    byte[] bytes = binary.Chunk(8).Select(c => Convert.ToByte(new string(c), 2)).ToArray();
    VirtualMachine vm = new(bytes);
    vm.Run();

    return 0;
}

static int ShowHelpMessage()
{
    Console.WriteLine($"Command line arguments:{Environment.NewLine}");

    Console.WriteLine($"{"run <Path>",-50}Runs the specified executable.");
    Console.WriteLine($"{"compile <Path> [OutFile] [-compact]",-50}Compiles the specified assembler source code.");
    Console.WriteLine($"{"disassemble <Path> [OutFile]",-50}Disassembles the specified executable.");
    return 0;
}

int DisplayError()
{
    Console.WriteLine($"Error: Invalid argument '{args[0]}'.");
    return -1;
}