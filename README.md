# Virtual Machine

This is a small virtual machine for a custom assembly language. The repository contains an assembler, disassembler and the virtual machine itself. This is an example program that displays the text "Hello World!":
````assembly
; Set register a to 1
str ra, 1

; Set register b to the string "Hello World!\n"
str rb, "Hello World!\n", 1

; Call interrupt procedure
int
````
Interacting with the virtual machine is done through the command-line application ``vm``. If this code is saved to the file ``hello.asm``, it can be compiled by the assembler using the command ``vm compile hello.asm``, yielding an executable called ``hello.bin``. That executable can then be run using the command ``vm run hello.bin``.

## Assembler

### Instructions
Every instruction is 10 bytes.
- 1 byte for the label
- 1 byte for the opcode
- 2 bytes each for each of the 4 operands

### Limitations
- A file cannot contain more than 255 lines of code.
- Only 255 distinct constants can be stored per file.
- A constant cannot be larger than 255 bytes.

### Instruction Set

#### Operand Types
|Type|Description
|---|---|
|r|Register|
|m|A memory address or constant value.|
|l|Label|
|t|Type; Currently unused.|

#### Instructions
|Opcode|Mnemonic|Description|Operand 1|Operand 2| Operand 3| Operand 4|
|---|---|---|---|---|---|---|
|00000000|Nop|Does nothing.|||||
|00000001|Ret|Exits the program.|||||
|00000010|Hlt|Exits the program.|||||
|00000011|Add|Adds two numbers. The register specified as operand 1 is set to the result.|r|r, m|||
|00000100|Sub|Subtracts two numbers. The register specified as operand 1 is set to the result.|r|r, m|||
|00000101|Mul|Multiplies two numbers. The register specified as operand 1 is set to the result.|r|r, m|||
|00000110|Div|Divides two numbers. The register specified as operand 1 is set to the result.|r|r, m|||
|00000111|Shl|Shifts operand 1's bits to the left by the bytes specified in operand 2. The register specified as operand 1 is set to the result.|r|r, m|||
|00001000|Shr|Shifts operand 1's bits to the right by the bytes specified in operand 2. The register specified as operand 1 is set to the result.|r|r, m|||
|00001001|Jmp|Jump unconditionally.|l||||
|00001010|Beq|Jump if equal.|r, m|r, m|l||
|00001011|Not|Negates the value of operand 1.|r||||
|00001100|And|And gate. The register specified as operand 1 is set to the result.|r|r, m|||
|00001101|Or|Or gate. The register specified as operand 1 is set to the result.|r|r, m|||
|00001110|Ceq|Checks if the two operands are equal. The register specified as operand 1 is set to the result.|r|r, m|||
|00001111|Cgt|Checks if operand 1 is greater than operand 2. The register specified as operand 1 is set to the result.|r|r, m|||
|00010000|Clt|Checks if operand 1 is smaller than operand 2. The register specified as operand 1 is set to the result.|r|r, m|||
|00010001|Xor|Exclusive or gate. The register specified as operand 1 is set to the result.|r|r, m|||
|00010010|Str|Sets the register specified as operand 1 to the value of operand 2.|r|r, m|m?||
|00010101|Rem|Calculates the remainder of a division of two numbers. The register specified as operand 1 is set to the result.|r|r, m|||
|00010111|Cnv|Currently no effect.|r|t|||
|00011000|Swp|Swaps two registers.|r|r|||
|00011001|Call|Calls a *function*. A specialized version of ``Jmp``. Currently no effect.|l||||
|00011010|Rtc|Returns from a function. Currently no effect.|||||
|00011011|Dfc|Declares a function. Currently no effect.|||||
|00011100|Int|Calls an interrupt routine.|||||
