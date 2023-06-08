//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.12.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Jonas\source\repos\VM\VM\Assembler\Parser\asm.g4 by ANTLR 4.12.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace VM.Assembler.Parser {
using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.CLSCompliant(false)]
public partial class asmParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, NewLine=7, Ws=8, Comment=9, 
		OpCode=10, Identifier=11, DecimalDigit=12, BinaryDigit=13, HexDigit=14, 
		Include=15, String=16, EscapeSequence=17;
	public const int
		RULE_global_include = 0, RULE_integer = 1, RULE_floating_point_number = 2, 
		RULE_operand = 3, RULE_label = 4, RULE_line_number = 5, RULE_instruction = 6, 
		RULE_include = 7, RULE_compilation_unit = 8;
	public static readonly string[] ruleNames = {
		"global_include", "integer", "floating_point_number", "operand", "label", 
		"line_number", "instruction", "include", "compilation_unit"
	};

	private static readonly string[] _LiteralNames = {
		null, "'0b'", "'0x'", "'.'", "':'", "'%'", "','", null, null, null, null, 
		null, null, null, null, "'INCLUDE'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, "NewLine", "Ws", "Comment", 
		"OpCode", "Identifier", "DecimalDigit", "BinaryDigit", "HexDigit", "Include", 
		"String", "EscapeSequence"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "asm.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static asmParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public asmParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public asmParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class Global_includeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Include() { return GetToken(asmParser.Include, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode String() { return GetToken(asmParser.String, 0); }
		public Global_includeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_global_include; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IasmListener typedListener = listener as IasmListener;
			if (typedListener != null) typedListener.EnterGlobal_include(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IasmListener typedListener = listener as IasmListener;
			if (typedListener != null) typedListener.ExitGlobal_include(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IasmVisitor<TResult> typedVisitor = visitor as IasmVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitGlobal_include(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Global_includeContext global_include() {
		Global_includeContext _localctx = new Global_includeContext(Context, State);
		EnterRule(_localctx, 0, RULE_global_include);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 18;
			Match(Include);
			State = 19;
			Match(String);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IntegerContext : ParserRuleContext {
		public IntegerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_integer; } }
	 
		public IntegerContext() { }
		public virtual void CopyFrom(IntegerContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class Decimal_literalContext : IntegerContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DecimalDigit() { return GetTokens(asmParser.DecimalDigit); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DecimalDigit(int i) {
			return GetToken(asmParser.DecimalDigit, i);
		}
		public Decimal_literalContext(IntegerContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IasmListener typedListener = listener as IasmListener;
			if (typedListener != null) typedListener.EnterDecimal_literal(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IasmListener typedListener = listener as IasmListener;
			if (typedListener != null) typedListener.ExitDecimal_literal(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IasmVisitor<TResult> typedVisitor = visitor as IasmVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDecimal_literal(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Hex_literalContext : IntegerContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] HexDigit() { return GetTokens(asmParser.HexDigit); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HexDigit(int i) {
			return GetToken(asmParser.HexDigit, i);
		}
		public Hex_literalContext(IntegerContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IasmListener typedListener = listener as IasmListener;
			if (typedListener != null) typedListener.EnterHex_literal(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IasmListener typedListener = listener as IasmListener;
			if (typedListener != null) typedListener.ExitHex_literal(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IasmVisitor<TResult> typedVisitor = visitor as IasmVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitHex_literal(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Binary_literalContext : IntegerContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] BinaryDigit() { return GetTokens(asmParser.BinaryDigit); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BinaryDigit(int i) {
			return GetToken(asmParser.BinaryDigit, i);
		}
		public Binary_literalContext(IntegerContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IasmListener typedListener = listener as IasmListener;
			if (typedListener != null) typedListener.EnterBinary_literal(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IasmListener typedListener = listener as IasmListener;
			if (typedListener != null) typedListener.ExitBinary_literal(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IasmVisitor<TResult> typedVisitor = visitor as IasmVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBinary_literal(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public IntegerContext integer() {
		IntegerContext _localctx = new IntegerContext(Context, State);
		EnterRule(_localctx, 2, RULE_integer);
		int _la;
		try {
			State = 38;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case DecimalDigit:
				_localctx = new Decimal_literalContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 22;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				do {
					{
					{
					State = 21;
					Match(DecimalDigit);
					}
					}
					State = 24;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				} while ( _la==DecimalDigit );
				}
				break;
			case T__0:
				_localctx = new Binary_literalContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 26;
				Match(T__0);
				State = 28;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				do {
					{
					{
					State = 27;
					Match(BinaryDigit);
					}
					}
					State = 30;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				} while ( _la==BinaryDigit );
				}
				break;
			case T__1:
				_localctx = new Hex_literalContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 32;
				Match(T__1);
				State = 34;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				do {
					{
					{
					State = 33;
					Match(HexDigit);
					}
					}
					State = 36;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				} while ( _la==HexDigit );
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Floating_point_numberContext : ParserRuleContext {
		public Floating_point_numberContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_floating_point_number; } }
	 
		public Floating_point_numberContext() { }
		public virtual void CopyFrom(Floating_point_numberContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class Binary_floatContext : Floating_point_numberContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] BinaryDigit() { return GetTokens(asmParser.BinaryDigit); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BinaryDigit(int i) {
			return GetToken(asmParser.BinaryDigit, i);
		}
		public Binary_floatContext(Floating_point_numberContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IasmListener typedListener = listener as IasmListener;
			if (typedListener != null) typedListener.EnterBinary_float(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IasmListener typedListener = listener as IasmListener;
			if (typedListener != null) typedListener.ExitBinary_float(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IasmVisitor<TResult> typedVisitor = visitor as IasmVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBinary_float(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Hex_floatContext : Floating_point_numberContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] HexDigit() { return GetTokens(asmParser.HexDigit); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HexDigit(int i) {
			return GetToken(asmParser.HexDigit, i);
		}
		public Hex_floatContext(Floating_point_numberContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IasmListener typedListener = listener as IasmListener;
			if (typedListener != null) typedListener.EnterHex_float(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IasmListener typedListener = listener as IasmListener;
			if (typedListener != null) typedListener.ExitHex_float(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IasmVisitor<TResult> typedVisitor = visitor as IasmVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitHex_float(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Decimal_floatContext : Floating_point_numberContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DecimalDigit() { return GetTokens(asmParser.DecimalDigit); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DecimalDigit(int i) {
			return GetToken(asmParser.DecimalDigit, i);
		}
		public Decimal_floatContext(Floating_point_numberContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IasmListener typedListener = listener as IasmListener;
			if (typedListener != null) typedListener.EnterDecimal_float(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IasmListener typedListener = listener as IasmListener;
			if (typedListener != null) typedListener.ExitDecimal_float(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IasmVisitor<TResult> typedVisitor = visitor as IasmVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDecimal_float(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Floating_point_numberContext floating_point_number() {
		Floating_point_numberContext _localctx = new Floating_point_numberContext(Context, State);
		EnterRule(_localctx, 4, RULE_floating_point_number);
		int _la;
		try {
			State = 78;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__2:
			case DecimalDigit:
				_localctx = new Decimal_floatContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 43;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==DecimalDigit) {
					{
					{
					State = 40;
					Match(DecimalDigit);
					}
					}
					State = 45;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 46;
				Match(T__2);
				State = 48;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				do {
					{
					{
					State = 47;
					Match(DecimalDigit);
					}
					}
					State = 50;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				} while ( _la==DecimalDigit );
				}
				break;
			case T__0:
				_localctx = new Binary_floatContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 52;
				Match(T__0);
				State = 56;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==BinaryDigit) {
					{
					{
					State = 53;
					Match(BinaryDigit);
					}
					}
					State = 58;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 59;
				Match(T__2);
				State = 61;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				do {
					{
					{
					State = 60;
					Match(BinaryDigit);
					}
					}
					State = 63;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				} while ( _la==BinaryDigit );
				}
				break;
			case T__1:
				_localctx = new Hex_floatContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 65;
				Match(T__1);
				State = 69;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==HexDigit) {
					{
					{
					State = 66;
					Match(HexDigit);
					}
					}
					State = 71;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 72;
				Match(T__2);
				State = 74;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				do {
					{
					{
					State = 73;
					Match(HexDigit);
					}
					}
					State = 76;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				} while ( _la==HexDigit );
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class OperandContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(asmParser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IntegerContext integer() {
			return GetRuleContext<IntegerContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Floating_point_numberContext floating_point_number() {
			return GetRuleContext<Floating_point_numberContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode String() { return GetToken(asmParser.String, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Line_numberContext line_number() {
			return GetRuleContext<Line_numberContext>(0);
		}
		public OperandContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_operand; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IasmListener typedListener = listener as IasmListener;
			if (typedListener != null) typedListener.EnterOperand(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IasmListener typedListener = listener as IasmListener;
			if (typedListener != null) typedListener.ExitOperand(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IasmVisitor<TResult> typedVisitor = visitor as IasmVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitOperand(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public OperandContext operand() {
		OperandContext _localctx = new OperandContext(Context, State);
		EnterRule(_localctx, 6, RULE_operand);
		try {
			State = 85;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,11,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 80;
				Match(Identifier);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 81;
				integer();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 82;
				floating_point_number();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 83;
				Match(String);
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 84;
				line_number();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LabelContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(asmParser.Identifier, 0); }
		public LabelContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_label; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IasmListener typedListener = listener as IasmListener;
			if (typedListener != null) typedListener.EnterLabel(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IasmListener typedListener = listener as IasmListener;
			if (typedListener != null) typedListener.ExitLabel(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IasmVisitor<TResult> typedVisitor = visitor as IasmVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLabel(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public LabelContext label() {
		LabelContext _localctx = new LabelContext(Context, State);
		EnterRule(_localctx, 8, RULE_label);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 87;
			Match(Identifier);
			State = 88;
			Match(T__3);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Line_numberContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DecimalDigit() { return GetTokens(asmParser.DecimalDigit); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DecimalDigit(int i) {
			return GetToken(asmParser.DecimalDigit, i);
		}
		public Line_numberContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_line_number; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IasmListener typedListener = listener as IasmListener;
			if (typedListener != null) typedListener.EnterLine_number(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IasmListener typedListener = listener as IasmListener;
			if (typedListener != null) typedListener.ExitLine_number(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IasmVisitor<TResult> typedVisitor = visitor as IasmVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLine_number(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Line_numberContext line_number() {
		Line_numberContext _localctx = new Line_numberContext(Context, State);
		EnterRule(_localctx, 10, RULE_line_number);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 90;
			Match(T__4);
			State = 92;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 91;
				Match(DecimalDigit);
				}
				}
				State = 94;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==DecimalDigit );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InstructionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpCode() { return GetToken(asmParser.OpCode, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] NewLine() { return GetTokens(asmParser.NewLine); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NewLine(int i) {
			return GetToken(asmParser.NewLine, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public LabelContext label() {
			return GetRuleContext<LabelContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public OperandContext[] operand() {
			return GetRuleContexts<OperandContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public OperandContext operand(int i) {
			return GetRuleContext<OperandContext>(i);
		}
		public InstructionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_instruction; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IasmListener typedListener = listener as IasmListener;
			if (typedListener != null) typedListener.EnterInstruction(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IasmListener typedListener = listener as IasmListener;
			if (typedListener != null) typedListener.ExitInstruction(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IasmVisitor<TResult> typedVisitor = visitor as IasmVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInstruction(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public InstructionContext instruction() {
		InstructionContext _localctx = new InstructionContext(Context, State);
		EnterRule(_localctx, 12, RULE_instruction);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 103;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Identifier) {
				{
				State = 96;
				label();
				State = 100;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==NewLine) {
					{
					{
					State = 97;
					Match(NewLine);
					}
					}
					State = 102;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				}
			}

			State = 105;
			Match(OpCode);
			State = 114;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & 71726L) != 0)) {
				{
				State = 106;
				operand();
				State = 111;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==T__5) {
					{
					{
					State = 107;
					Match(T__5);
					State = 108;
					operand();
					}
					}
					State = 113;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				}
			}

			State = 116;
			Match(NewLine);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IncludeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Include() { return GetToken(asmParser.Include, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode String() { return GetToken(asmParser.String, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] NewLine() { return GetTokens(asmParser.NewLine); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NewLine(int i) {
			return GetToken(asmParser.NewLine, i);
		}
		public IncludeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_include; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IasmListener typedListener = listener as IasmListener;
			if (typedListener != null) typedListener.EnterInclude(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IasmListener typedListener = listener as IasmListener;
			if (typedListener != null) typedListener.ExitInclude(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IasmVisitor<TResult> typedVisitor = visitor as IasmVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInclude(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public IncludeContext include() {
		IncludeContext _localctx = new IncludeContext(Context, State);
		EnterRule(_localctx, 14, RULE_include);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 118;
			Match(Include);
			State = 119;
			Match(String);
			State = 121;
			ErrorHandler.Sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					State = 120;
					Match(NewLine);
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 123;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,17,Context);
			} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Compilation_unitContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(asmParser.Eof, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IncludeContext[] include() {
			return GetRuleContexts<IncludeContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public IncludeContext include(int i) {
			return GetRuleContext<IncludeContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] NewLine() { return GetTokens(asmParser.NewLine); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NewLine(int i) {
			return GetToken(asmParser.NewLine, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public InstructionContext[] instruction() {
			return GetRuleContexts<InstructionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public InstructionContext instruction(int i) {
			return GetRuleContext<InstructionContext>(i);
		}
		public Compilation_unitContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_compilation_unit; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IasmListener typedListener = listener as IasmListener;
			if (typedListener != null) typedListener.EnterCompilation_unit(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IasmListener typedListener = listener as IasmListener;
			if (typedListener != null) typedListener.ExitCompilation_unit(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IasmVisitor<TResult> typedVisitor = visitor as IasmVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCompilation_unit(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Compilation_unitContext compilation_unit() {
		Compilation_unitContext _localctx = new Compilation_unitContext(Context, State);
		EnterRule(_localctx, 16, RULE_compilation_unit);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 129;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,19,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					State = 127;
					ErrorHandler.Sync(this);
					switch (TokenStream.LA(1)) {
					case Include:
						{
						State = 125;
						include();
						}
						break;
					case NewLine:
						{
						State = 126;
						Match(NewLine);
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					} 
				}
				State = 131;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,19,Context);
			}
			State = 136;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 3200L) != 0)) {
				{
				State = 134;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case OpCode:
				case Identifier:
					{
					State = 132;
					instruction();
					}
					break;
				case NewLine:
					{
					State = 133;
					Match(NewLine);
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				State = 138;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 139;
			Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static int[] _serializedATN = {
		4,1,17,142,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,2,7,
		7,7,2,8,7,8,1,0,1,0,1,0,1,1,4,1,23,8,1,11,1,12,1,24,1,1,1,1,4,1,29,8,1,
		11,1,12,1,30,1,1,1,1,4,1,35,8,1,11,1,12,1,36,3,1,39,8,1,1,2,5,2,42,8,2,
		10,2,12,2,45,9,2,1,2,1,2,4,2,49,8,2,11,2,12,2,50,1,2,1,2,5,2,55,8,2,10,
		2,12,2,58,9,2,1,2,1,2,4,2,62,8,2,11,2,12,2,63,1,2,1,2,5,2,68,8,2,10,2,
		12,2,71,9,2,1,2,1,2,4,2,75,8,2,11,2,12,2,76,3,2,79,8,2,1,3,1,3,1,3,1,3,
		1,3,3,3,86,8,3,1,4,1,4,1,4,1,5,1,5,4,5,93,8,5,11,5,12,5,94,1,6,1,6,5,6,
		99,8,6,10,6,12,6,102,9,6,3,6,104,8,6,1,6,1,6,1,6,1,6,5,6,110,8,6,10,6,
		12,6,113,9,6,3,6,115,8,6,1,6,1,6,1,7,1,7,1,7,4,7,122,8,7,11,7,12,7,123,
		1,8,1,8,5,8,128,8,8,10,8,12,8,131,9,8,1,8,1,8,5,8,135,8,8,10,8,12,8,138,
		9,8,1,8,1,8,1,8,0,0,9,0,2,4,6,8,10,12,14,16,0,0,159,0,18,1,0,0,0,2,38,
		1,0,0,0,4,78,1,0,0,0,6,85,1,0,0,0,8,87,1,0,0,0,10,90,1,0,0,0,12,103,1,
		0,0,0,14,118,1,0,0,0,16,129,1,0,0,0,18,19,5,15,0,0,19,20,5,16,0,0,20,1,
		1,0,0,0,21,23,5,12,0,0,22,21,1,0,0,0,23,24,1,0,0,0,24,22,1,0,0,0,24,25,
		1,0,0,0,25,39,1,0,0,0,26,28,5,1,0,0,27,29,5,13,0,0,28,27,1,0,0,0,29,30,
		1,0,0,0,30,28,1,0,0,0,30,31,1,0,0,0,31,39,1,0,0,0,32,34,5,2,0,0,33,35,
		5,14,0,0,34,33,1,0,0,0,35,36,1,0,0,0,36,34,1,0,0,0,36,37,1,0,0,0,37,39,
		1,0,0,0,38,22,1,0,0,0,38,26,1,0,0,0,38,32,1,0,0,0,39,3,1,0,0,0,40,42,5,
		12,0,0,41,40,1,0,0,0,42,45,1,0,0,0,43,41,1,0,0,0,43,44,1,0,0,0,44,46,1,
		0,0,0,45,43,1,0,0,0,46,48,5,3,0,0,47,49,5,12,0,0,48,47,1,0,0,0,49,50,1,
		0,0,0,50,48,1,0,0,0,50,51,1,0,0,0,51,79,1,0,0,0,52,56,5,1,0,0,53,55,5,
		13,0,0,54,53,1,0,0,0,55,58,1,0,0,0,56,54,1,0,0,0,56,57,1,0,0,0,57,59,1,
		0,0,0,58,56,1,0,0,0,59,61,5,3,0,0,60,62,5,13,0,0,61,60,1,0,0,0,62,63,1,
		0,0,0,63,61,1,0,0,0,63,64,1,0,0,0,64,79,1,0,0,0,65,69,5,2,0,0,66,68,5,
		14,0,0,67,66,1,0,0,0,68,71,1,0,0,0,69,67,1,0,0,0,69,70,1,0,0,0,70,72,1,
		0,0,0,71,69,1,0,0,0,72,74,5,3,0,0,73,75,5,14,0,0,74,73,1,0,0,0,75,76,1,
		0,0,0,76,74,1,0,0,0,76,77,1,0,0,0,77,79,1,0,0,0,78,43,1,0,0,0,78,52,1,
		0,0,0,78,65,1,0,0,0,79,5,1,0,0,0,80,86,5,11,0,0,81,86,3,2,1,0,82,86,3,
		4,2,0,83,86,5,16,0,0,84,86,3,10,5,0,85,80,1,0,0,0,85,81,1,0,0,0,85,82,
		1,0,0,0,85,83,1,0,0,0,85,84,1,0,0,0,86,7,1,0,0,0,87,88,5,11,0,0,88,89,
		5,4,0,0,89,9,1,0,0,0,90,92,5,5,0,0,91,93,5,12,0,0,92,91,1,0,0,0,93,94,
		1,0,0,0,94,92,1,0,0,0,94,95,1,0,0,0,95,11,1,0,0,0,96,100,3,8,4,0,97,99,
		5,7,0,0,98,97,1,0,0,0,99,102,1,0,0,0,100,98,1,0,0,0,100,101,1,0,0,0,101,
		104,1,0,0,0,102,100,1,0,0,0,103,96,1,0,0,0,103,104,1,0,0,0,104,105,1,0,
		0,0,105,114,5,10,0,0,106,111,3,6,3,0,107,108,5,6,0,0,108,110,3,6,3,0,109,
		107,1,0,0,0,110,113,1,0,0,0,111,109,1,0,0,0,111,112,1,0,0,0,112,115,1,
		0,0,0,113,111,1,0,0,0,114,106,1,0,0,0,114,115,1,0,0,0,115,116,1,0,0,0,
		116,117,5,7,0,0,117,13,1,0,0,0,118,119,5,15,0,0,119,121,5,16,0,0,120,122,
		5,7,0,0,121,120,1,0,0,0,122,123,1,0,0,0,123,121,1,0,0,0,123,124,1,0,0,
		0,124,15,1,0,0,0,125,128,3,14,7,0,126,128,5,7,0,0,127,125,1,0,0,0,127,
		126,1,0,0,0,128,131,1,0,0,0,129,127,1,0,0,0,129,130,1,0,0,0,130,136,1,
		0,0,0,131,129,1,0,0,0,132,135,3,12,6,0,133,135,5,7,0,0,134,132,1,0,0,0,
		134,133,1,0,0,0,135,138,1,0,0,0,136,134,1,0,0,0,136,137,1,0,0,0,137,139,
		1,0,0,0,138,136,1,0,0,0,139,140,5,0,0,1,140,17,1,0,0,0,22,24,30,36,38,
		43,50,56,63,69,76,78,85,94,100,103,111,114,123,127,129,134,136
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace VM.Assembler.Parser
