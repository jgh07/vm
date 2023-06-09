using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using VM;
using VM.Assembler;

if (args.Length == 0)
    args = new string[1] { "test.lsm" };

if (args[0] == "run")
{
    string binary = File.ReadAllText(args[1]);

    binary = binary
            .Replace(" ", "")
            .Replace("\r", "")
            .Replace("\n", "");

    byte[] bytes = binary.Chunk(8).Select(c => Convert.ToByte(new string(c), 2)).ToArray();
    VirtualMachine vm = new(bytes);
    vm.Run();

    return;
}

Stopwatch sw = new();
sw.Start();

Assembler.Compile(File.ReadAllText(args[0]), "test.bin");

sw.Stop();
Console.WriteLine($"Elapsed: {sw.Elapsed.TotalMilliseconds}ms");

File.WriteAllText("simplified.bin", File.ReadAllText("test.bin")
    .Replace(" ", "")
    .Replace("\r", "")
    .Replace("\n", ""));

File.WriteAllText("disassembly.lsm", Assembler.Disassemble(File.ReadAllText("test.bin")));