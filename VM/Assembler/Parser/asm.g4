grammar asm;

NewLine: ('\r\n' | '\r' | '\n' | '\u0085' | '\u2028' | '\u2029');
Comment: ';' .* NewLine+ -> skip;

Identifier: ([Aa-Zz] | '_')+;

fragment DecimalDigit: [0-9];
fragment BinaryDigit: [0-1];
fragment HexDigit: [0-9Aa-Ff];

fragment A: [aA];
fragment B: [bB];
fragment C: [cC];
fragment D: [dD];
fragment E: [eE];
fragment F: [fF];
fragment G: [gG];
fragment H: [hH];
fragment I: [iI];
fragment J: [jJ];
fragment K: [kK];
fragment L: [lL];
fragment M: [mM];
fragment N: [nN];
fragment O: [oO];
fragment P: [pP];
fragment Q: [qQ];
fragment R: [rR];
fragment S: [sS];
fragment T: [tT];
fragment U: [uU];
fragment V: [vV];
fragment W: [wW];
fragment X: [xX];
fragment Y: [yY];
fragment Z: [zZ];

Nop: N O P;
Ret: R E T;
Hlt: H L T;
Add: A D D;
Sub: S U B;
Mul: M U L;
Div: D I V;
Shl: S H L;
Shr: S H R;
Jmp: J M P;
Beq: B E Q;
Not: N O T;
And: A N D;
Or: O R;
Ceq: C E Q;
Cgt: C G T;
Clt: C L T;
Xor: X O R;
Sti: S T I;
Stf: S T F;
Sts: S T S;
Rem: R E M;
Str: S T R;
Cnv: C N V;

Skp: S K P;
Dfr: D F R;
Start: S T A R T;
Public: P U B L I C;
Private: P R I V A T E;

Include: I N C L U D E;

String: '"' (~[^"\r\n\u0085\u2028\u2029] | EscapeSequence)* '"';

EscapeSequence: '\\\\' | '\\r' | '\\n' | '\\"';

global_include
    : Include String
    ;

integer
    : DecimalDigit+ #decimal_literal
    | '0b' BinaryDigit+ #binary_literal
    | '0x' HexDigit+ #hex_literal
    ;

float
    : DecimalDigit* '.' DecimalDigit+ #decimal_float
    | '0b' BinaryDigit* '.' BinaryDigit+ #binary_float
    | '0x' HexDigit* '.' HexDigit+ #hex_float
    ;

op_code
    : Nop | Ret | Hlt | Add | Sub | Mul | Div | Shl | Shr | Jmp | Beq | Not | And | Or | Ceq | Xor | Sti | Stf | Sts | Rem | Str | Cnv;

operand
    : Identifier | integer | float | String
    ;

label
    : Identifier ':'
    ;

instruction
    : label? op_code (operand (';' operand)?)? NewLine
    ;

procedure_modifier
    : (Skp | Dfr | Start | Public | Private) NewLine?
    ;

procedure
    : procedure_modifier* Identifier '{' instruction* '}' NewLine*
    ;

include
    : Include String NewLine+
    ;

compilation_unit
    : (include | NewLine)* (procedure | NewLine)*
    ;