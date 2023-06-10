grammar asm;

options { caseInsensitive = true; }

NewLine: ('\r\n' | '\r' | '\n' | '\u0085' | '\u2028' | '\u2029');
Ws: [ \t]+ -> skip;
Comment: ';' .*? NewLine+ -> skip;

OpCode: 'NOP' | 'RET' | 'HLT' | 'ADD' | 'SUB' | 'MUL' | 'DIV' | 'SHL' | 'SHR' | 'JMP' | 'BEQ' | 'NOT' | 'AND' | 'OR' | 'CEQ' | 'CGT' | 'CLT' | 'XOR' | 'STR' | 'REM' | 'CNV' | 'SWP' | 'CALL' | 'RTC' | 'DFC' | 'INT';

Identifier: ([a-z] | [A-Z] | '_') ([a-z] | [A-Z] | '_' | [0-9])*;

DecimalDigit: [0-9];
BinaryDigit: [0-1];
HexDigit: ([0-9] | [a-f] | [A-F]);

Include: 'INCLUDE';

String: '"' (~[\\"\r\n\u0085\u2028\u2029] | EscapeSequence)* '"';

EscapeSequence: '\\\\' | '\\r' | '\\n' | '\\"' | '\\b';

global_include
    : Include String
    ;

integer
    : DecimalDigit+ #decimal_literal
    | '0b' BinaryDigit+ #binary_literal
    | '0x' HexDigit+ #hex_literal
    ;

floating_point_number
    : DecimalDigit* '.' DecimalDigit+ #decimal_float
    | '0b' BinaryDigit* '.' BinaryDigit+ #binary_float
    | '0x' HexDigit* '.' HexDigit+ #hex_float
    ;

operand
    : Identifier | integer | floating_point_number | String | line_number
    ;

label
    : Identifier ':'
    ;

line_number
    : '%' DecimalDigit+
    ;

instruction
    : (label NewLine*)? OpCode (operand (',' operand)*)? NewLine
    ;

include
    : Include String NewLine+
    ;

compilation_unit
    : (include | NewLine)* (instruction | NewLine)* EOF
    ;