//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.12.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Jonas\Source\Repos\jgh07\vm\VM\Assembler\Parser\asm.g4 by ANTLR 4.12.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace VM.Assembler.Parser {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="asmParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.CLSCompliant(false)]
public interface IasmListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="asmParser.global_include"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGlobal_include([NotNull] asmParser.Global_includeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="asmParser.global_include"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGlobal_include([NotNull] asmParser.Global_includeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="asmParser.constant_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstant_definition([NotNull] asmParser.Constant_definitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="asmParser.constant_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstant_definition([NotNull] asmParser.Constant_definitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="asmParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstant([NotNull] asmParser.ConstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="asmParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstant([NotNull] asmParser.ConstantContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>decimal_literal</c>
	/// labeled alternative in <see cref="asmParser.integer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecimal_literal([NotNull] asmParser.Decimal_literalContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>decimal_literal</c>
	/// labeled alternative in <see cref="asmParser.integer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecimal_literal([NotNull] asmParser.Decimal_literalContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>binary_literal</c>
	/// labeled alternative in <see cref="asmParser.integer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBinary_literal([NotNull] asmParser.Binary_literalContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>binary_literal</c>
	/// labeled alternative in <see cref="asmParser.integer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBinary_literal([NotNull] asmParser.Binary_literalContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>hex_literal</c>
	/// labeled alternative in <see cref="asmParser.integer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHex_literal([NotNull] asmParser.Hex_literalContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>hex_literal</c>
	/// labeled alternative in <see cref="asmParser.integer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHex_literal([NotNull] asmParser.Hex_literalContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>decimal_float</c>
	/// labeled alternative in <see cref="asmParser.floating_point_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecimal_float([NotNull] asmParser.Decimal_floatContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>decimal_float</c>
	/// labeled alternative in <see cref="asmParser.floating_point_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecimal_float([NotNull] asmParser.Decimal_floatContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>binary_float</c>
	/// labeled alternative in <see cref="asmParser.floating_point_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBinary_float([NotNull] asmParser.Binary_floatContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>binary_float</c>
	/// labeled alternative in <see cref="asmParser.floating_point_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBinary_float([NotNull] asmParser.Binary_floatContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>hex_float</c>
	/// labeled alternative in <see cref="asmParser.floating_point_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHex_float([NotNull] asmParser.Hex_floatContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>hex_float</c>
	/// labeled alternative in <see cref="asmParser.floating_point_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHex_float([NotNull] asmParser.Hex_floatContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="asmParser.operand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperand([NotNull] asmParser.OperandContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="asmParser.operand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperand([NotNull] asmParser.OperandContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="asmParser.label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLabel([NotNull] asmParser.LabelContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="asmParser.label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLabel([NotNull] asmParser.LabelContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="asmParser.line_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLine_number([NotNull] asmParser.Line_numberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="asmParser.line_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLine_number([NotNull] asmParser.Line_numberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="asmParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstruction([NotNull] asmParser.InstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="asmParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstruction([NotNull] asmParser.InstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="asmParser.include"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInclude([NotNull] asmParser.IncludeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="asmParser.include"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInclude([NotNull] asmParser.IncludeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="asmParser.compilation_unit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompilation_unit([NotNull] asmParser.Compilation_unitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="asmParser.compilation_unit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompilation_unit([NotNull] asmParser.Compilation_unitContext context);
}
} // namespace VM.Assembler.Parser
