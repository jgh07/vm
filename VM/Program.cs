using System;
using System.Diagnostics;
using System.IO;
using VM.Assembler;

if (args.Length == 0)
    args = new string[1] { "test.lsm" };

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