# Virtual Machine

## Assembler

### Instructions
Every instruction is 10 bytes.
- 1 byte for the label
- 1 byte for the opcode
- 2 bytes each for each of the 4 operands

### Syntax
````assembly
; This is a comment.

include "file2.lsm"

__main:
    str ra, 1
    str rb, 2
    ceq ra, rb
    call someFuncFromFile2
    jmp __main
````

### Limitations
- A file cannot contain more than 255 lines of code.
- Only 255 distinct constants can be stored per file.
- A constant cannot be larger than 255 bytes.
- Labels can only be accessed after they have been defined. Before that, you can only jump to line numbers.

### Instruction Set

#### Operand Types
|Type|Description
|---|---|
|r|Register|
|m|A memory address. Constants are automatically assigned their place in memory.|
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
|00001101|And|Or gate. The register specified as operand 1 is set to the result.|r|r, m|||
|00001110|Ceq|Checks if the two operands are equal. The register specified as operand 1 is set to the result.|r|r, m|||
|00001111|Cgt|Checks if operand 1 is greater than operand 2. The register specified as operand 1 is set to the result.|r|r, m|||
|00010000|Clt|Checks if operand 1 is smaller than operand 2. The register specified as operand 1 is set to the result.|r|r, m|||
|00010001|Xor|Exclusive or gate. The register specified as operand 1 is set to the result.|r|r, m|||
|00010010|Str|Sets the register specified as operand 1 to the value of operand 2.|r|r, m|||
|00010101|Rem|Calculates the remainder of a division of two numbers. The register specified as operand 1 is set to the result.|r|r, m|||
|00010111|Cnv|Currently no effect.|r|t|||
|00011000|Swp|Swaps two registers.|r|r|||
|00011001|Call|Calls a *function*. A specialized version of ``Jmp``.|l||||
|00011010|Rtc|Returns from a function.|||||
|00011011|Dfc|Declares a function.|||||
|00011100|Dfc|Interrupt.|||||
