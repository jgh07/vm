// Generated from c:\Users\Jonas\source\repos\VM\VM\Assembler\Parser\asm.g4 by ANTLR 4.9.2
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class asmParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.9.2", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, NewLine=7, Ws=8, Comment=9, 
		OpCode=10, Identifier=11, DecimalDigit=12, BinaryDigit=13, HexDigit=14, 
		Include=15, String=16, EscapeSequence=17;
	public static final int
		RULE_global_include = 0, RULE_integer = 1, RULE_floating_point_number = 2, 
		RULE_operand = 3, RULE_label = 4, RULE_line_number = 5, RULE_instruction = 6, 
		RULE_include = 7, RULE_compilation_unit = 8;
	private static String[] makeRuleNames() {
		return new String[] {
			"global_include", "integer", "floating_point_number", "operand", "label", 
			"line_number", "instruction", "include", "compilation_unit"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "'0b'", "'0x'", "'.'", "':'", "'%'", "','", null, null, null, null, 
			null, null, null, null, "'INCLUDE'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, null, null, null, null, null, null, "NewLine", "Ws", "Comment", 
			"OpCode", "Identifier", "DecimalDigit", "BinaryDigit", "HexDigit", "Include", 
			"String", "EscapeSequence"
		};
	}
	private static final String[] _SYMBOLIC_NAMES = makeSymbolicNames();
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}

	@Override
	public String getGrammarFileName() { return "asm.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public asmParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	public static class Global_includeContext extends ParserRuleContext {
		public TerminalNode Include() { return getToken(asmParser.Include, 0); }
		public TerminalNode String() { return getToken(asmParser.String, 0); }
		public Global_includeContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_global_include; }
	}

	public final Global_includeContext global_include() throws RecognitionException {
		Global_includeContext _localctx = new Global_includeContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_global_include);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(18);
			match(Include);
			setState(19);
			match(String);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class IntegerContext extends ParserRuleContext {
		public IntegerContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_integer; }
	 
		public IntegerContext() { }
		public void copyFrom(IntegerContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class Decimal_literalContext extends IntegerContext {
		public List<TerminalNode> DecimalDigit() { return getTokens(asmParser.DecimalDigit); }
		public TerminalNode DecimalDigit(int i) {
			return getToken(asmParser.DecimalDigit, i);
		}
		public Decimal_literalContext(IntegerContext ctx) { copyFrom(ctx); }
	}
	public static class Hex_literalContext extends IntegerContext {
		public List<TerminalNode> HexDigit() { return getTokens(asmParser.HexDigit); }
		public TerminalNode HexDigit(int i) {
			return getToken(asmParser.HexDigit, i);
		}
		public Hex_literalContext(IntegerContext ctx) { copyFrom(ctx); }
	}
	public static class Binary_literalContext extends IntegerContext {
		public List<TerminalNode> BinaryDigit() { return getTokens(asmParser.BinaryDigit); }
		public TerminalNode BinaryDigit(int i) {
			return getToken(asmParser.BinaryDigit, i);
		}
		public Binary_literalContext(IntegerContext ctx) { copyFrom(ctx); }
	}

	public final IntegerContext integer() throws RecognitionException {
		IntegerContext _localctx = new IntegerContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_integer);
		int _la;
		try {
			setState(38);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case DecimalDigit:
				_localctx = new Decimal_literalContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(22); 
				_errHandler.sync(this);
				_la = _input.LA(1);
				do {
					{
					{
					setState(21);
					match(DecimalDigit);
					}
					}
					setState(24); 
					_errHandler.sync(this);
					_la = _input.LA(1);
				} while ( _la==DecimalDigit );
				}
				break;
			case T__0:
				_localctx = new Binary_literalContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(26);
				match(T__0);
				setState(28); 
				_errHandler.sync(this);
				_la = _input.LA(1);
				do {
					{
					{
					setState(27);
					match(BinaryDigit);
					}
					}
					setState(30); 
					_errHandler.sync(this);
					_la = _input.LA(1);
				} while ( _la==BinaryDigit );
				}
				break;
			case T__1:
				_localctx = new Hex_literalContext(_localctx);
				enterOuterAlt(_localctx, 3);
				{
				setState(32);
				match(T__1);
				setState(34); 
				_errHandler.sync(this);
				_la = _input.LA(1);
				do {
					{
					{
					setState(33);
					match(HexDigit);
					}
					}
					setState(36); 
					_errHandler.sync(this);
					_la = _input.LA(1);
				} while ( _la==HexDigit );
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Floating_point_numberContext extends ParserRuleContext {
		public Floating_point_numberContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_floating_point_number; }
	 
		public Floating_point_numberContext() { }
		public void copyFrom(Floating_point_numberContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class Binary_floatContext extends Floating_point_numberContext {
		public List<TerminalNode> BinaryDigit() { return getTokens(asmParser.BinaryDigit); }
		public TerminalNode BinaryDigit(int i) {
			return getToken(asmParser.BinaryDigit, i);
		}
		public Binary_floatContext(Floating_point_numberContext ctx) { copyFrom(ctx); }
	}
	public static class Hex_floatContext extends Floating_point_numberContext {
		public List<TerminalNode> HexDigit() { return getTokens(asmParser.HexDigit); }
		public TerminalNode HexDigit(int i) {
			return getToken(asmParser.HexDigit, i);
		}
		public Hex_floatContext(Floating_point_numberContext ctx) { copyFrom(ctx); }
	}
	public static class Decimal_floatContext extends Floating_point_numberContext {
		public List<TerminalNode> DecimalDigit() { return getTokens(asmParser.DecimalDigit); }
		public TerminalNode DecimalDigit(int i) {
			return getToken(asmParser.DecimalDigit, i);
		}
		public Decimal_floatContext(Floating_point_numberContext ctx) { copyFrom(ctx); }
	}

	public final Floating_point_numberContext floating_point_number() throws RecognitionException {
		Floating_point_numberContext _localctx = new Floating_point_numberContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_floating_point_number);
		int _la;
		try {
			setState(78);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case T__2:
			case DecimalDigit:
				_localctx = new Decimal_floatContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(43);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while (_la==DecimalDigit) {
					{
					{
					setState(40);
					match(DecimalDigit);
					}
					}
					setState(45);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				setState(46);
				match(T__2);
				setState(48); 
				_errHandler.sync(this);
				_la = _input.LA(1);
				do {
					{
					{
					setState(47);
					match(DecimalDigit);
					}
					}
					setState(50); 
					_errHandler.sync(this);
					_la = _input.LA(1);
				} while ( _la==DecimalDigit );
				}
				break;
			case T__0:
				_localctx = new Binary_floatContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(52);
				match(T__0);
				setState(56);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while (_la==BinaryDigit) {
					{
					{
					setState(53);
					match(BinaryDigit);
					}
					}
					setState(58);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				setState(59);
				match(T__2);
				setState(61); 
				_errHandler.sync(this);
				_la = _input.LA(1);
				do {
					{
					{
					setState(60);
					match(BinaryDigit);
					}
					}
					setState(63); 
					_errHandler.sync(this);
					_la = _input.LA(1);
				} while ( _la==BinaryDigit );
				}
				break;
			case T__1:
				_localctx = new Hex_floatContext(_localctx);
				enterOuterAlt(_localctx, 3);
				{
				setState(65);
				match(T__1);
				setState(69);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while (_la==HexDigit) {
					{
					{
					setState(66);
					match(HexDigit);
					}
					}
					setState(71);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				setState(72);
				match(T__2);
				setState(74); 
				_errHandler.sync(this);
				_la = _input.LA(1);
				do {
					{
					{
					setState(73);
					match(HexDigit);
					}
					}
					setState(76); 
					_errHandler.sync(this);
					_la = _input.LA(1);
				} while ( _la==HexDigit );
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class OperandContext extends ParserRuleContext {
		public TerminalNode Identifier() { return getToken(asmParser.Identifier, 0); }
		public IntegerContext integer() {
			return getRuleContext(IntegerContext.class,0);
		}
		public Floating_point_numberContext floating_point_number() {
			return getRuleContext(Floating_point_numberContext.class,0);
		}
		public TerminalNode String() { return getToken(asmParser.String, 0); }
		public Line_numberContext line_number() {
			return getRuleContext(Line_numberContext.class,0);
		}
		public OperandContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_operand; }
	}

	public final OperandContext operand() throws RecognitionException {
		OperandContext _localctx = new OperandContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_operand);
		try {
			setState(85);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,11,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(80);
				match(Identifier);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(81);
				integer();
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(82);
				floating_point_number();
				}
				break;
			case 4:
				enterOuterAlt(_localctx, 4);
				{
				setState(83);
				match(String);
				}
				break;
			case 5:
				enterOuterAlt(_localctx, 5);
				{
				setState(84);
				line_number();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class LabelContext extends ParserRuleContext {
		public TerminalNode Identifier() { return getToken(asmParser.Identifier, 0); }
		public LabelContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_label; }
	}

	public final LabelContext label() throws RecognitionException {
		LabelContext _localctx = new LabelContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_label);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(87);
			match(Identifier);
			setState(88);
			match(T__3);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Line_numberContext extends ParserRuleContext {
		public List<TerminalNode> DecimalDigit() { return getTokens(asmParser.DecimalDigit); }
		public TerminalNode DecimalDigit(int i) {
			return getToken(asmParser.DecimalDigit, i);
		}
		public Line_numberContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_line_number; }
	}

	public final Line_numberContext line_number() throws RecognitionException {
		Line_numberContext _localctx = new Line_numberContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_line_number);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(90);
			match(T__4);
			setState(92); 
			_errHandler.sync(this);
			_la = _input.LA(1);
			do {
				{
				{
				setState(91);
				match(DecimalDigit);
				}
				}
				setState(94); 
				_errHandler.sync(this);
				_la = _input.LA(1);
			} while ( _la==DecimalDigit );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class InstructionContext extends ParserRuleContext {
		public TerminalNode OpCode() { return getToken(asmParser.OpCode, 0); }
		public List<TerminalNode> NewLine() { return getTokens(asmParser.NewLine); }
		public TerminalNode NewLine(int i) {
			return getToken(asmParser.NewLine, i);
		}
		public LabelContext label() {
			return getRuleContext(LabelContext.class,0);
		}
		public List<OperandContext> operand() {
			return getRuleContexts(OperandContext.class);
		}
		public OperandContext operand(int i) {
			return getRuleContext(OperandContext.class,i);
		}
		public InstructionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_instruction; }
	}

	public final InstructionContext instruction() throws RecognitionException {
		InstructionContext _localctx = new InstructionContext(_ctx, getState());
		enterRule(_localctx, 12, RULE_instruction);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(103);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==Identifier) {
				{
				setState(96);
				label();
				setState(100);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while (_la==NewLine) {
					{
					{
					setState(97);
					match(NewLine);
					}
					}
					setState(102);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				}
			}

			setState(105);
			match(OpCode);
			setState(114);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__4) | (1L << Identifier) | (1L << DecimalDigit) | (1L << String))) != 0)) {
				{
				setState(106);
				operand();
				setState(111);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while (_la==T__5) {
					{
					{
					setState(107);
					match(T__5);
					setState(108);
					operand();
					}
					}
					setState(113);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				}
			}

			setState(116);
			match(NewLine);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class IncludeContext extends ParserRuleContext {
		public TerminalNode Include() { return getToken(asmParser.Include, 0); }
		public TerminalNode String() { return getToken(asmParser.String, 0); }
		public List<TerminalNode> NewLine() { return getTokens(asmParser.NewLine); }
		public TerminalNode NewLine(int i) {
			return getToken(asmParser.NewLine, i);
		}
		public IncludeContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_include; }
	}

	public final IncludeContext include() throws RecognitionException {
		IncludeContext _localctx = new IncludeContext(_ctx, getState());
		enterRule(_localctx, 14, RULE_include);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(118);
			match(Include);
			setState(119);
			match(String);
			setState(121); 
			_errHandler.sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					setState(120);
					match(NewLine);
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				setState(123); 
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,17,_ctx);
			} while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Compilation_unitContext extends ParserRuleContext {
		public TerminalNode EOF() { return getToken(asmParser.EOF, 0); }
		public List<IncludeContext> include() {
			return getRuleContexts(IncludeContext.class);
		}
		public IncludeContext include(int i) {
			return getRuleContext(IncludeContext.class,i);
		}
		public List<TerminalNode> NewLine() { return getTokens(asmParser.NewLine); }
		public TerminalNode NewLine(int i) {
			return getToken(asmParser.NewLine, i);
		}
		public List<InstructionContext> instruction() {
			return getRuleContexts(InstructionContext.class);
		}
		public InstructionContext instruction(int i) {
			return getRuleContext(InstructionContext.class,i);
		}
		public Compilation_unitContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_compilation_unit; }
	}

	public final Compilation_unitContext compilation_unit() throws RecognitionException {
		Compilation_unitContext _localctx = new Compilation_unitContext(_ctx, getState());
		enterRule(_localctx, 16, RULE_compilation_unit);
		int _la;
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(129);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,19,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					setState(127);
					_errHandler.sync(this);
					switch (_input.LA(1)) {
					case Include:
						{
						setState(125);
						include();
						}
						break;
					case NewLine:
						{
						setState(126);
						match(NewLine);
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					} 
				}
				setState(131);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,19,_ctx);
			}
			setState(136);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << NewLine) | (1L << OpCode) | (1L << Identifier))) != 0)) {
				{
				setState(134);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case OpCode:
				case Identifier:
					{
					setState(132);
					instruction();
					}
					break;
				case NewLine:
					{
					setState(133);
					match(NewLine);
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				setState(138);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(139);
			match(EOF);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3\23\u0090\4\2\t\2"+
		"\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\3\2\3"+
		"\2\3\2\3\3\6\3\31\n\3\r\3\16\3\32\3\3\3\3\6\3\37\n\3\r\3\16\3 \3\3\3\3"+
		"\6\3%\n\3\r\3\16\3&\5\3)\n\3\3\4\7\4,\n\4\f\4\16\4/\13\4\3\4\3\4\6\4\63"+
		"\n\4\r\4\16\4\64\3\4\3\4\7\49\n\4\f\4\16\4<\13\4\3\4\3\4\6\4@\n\4\r\4"+
		"\16\4A\3\4\3\4\7\4F\n\4\f\4\16\4I\13\4\3\4\3\4\6\4M\n\4\r\4\16\4N\5\4"+
		"Q\n\4\3\5\3\5\3\5\3\5\3\5\5\5X\n\5\3\6\3\6\3\6\3\7\3\7\6\7_\n\7\r\7\16"+
		"\7`\3\b\3\b\7\be\n\b\f\b\16\bh\13\b\5\bj\n\b\3\b\3\b\3\b\3\b\7\bp\n\b"+
		"\f\b\16\bs\13\b\5\bu\n\b\3\b\3\b\3\t\3\t\3\t\6\t|\n\t\r\t\16\t}\3\n\3"+
		"\n\7\n\u0082\n\n\f\n\16\n\u0085\13\n\3\n\3\n\7\n\u0089\n\n\f\n\16\n\u008c"+
		"\13\n\3\n\3\n\3\n\2\2\13\2\4\6\b\n\f\16\20\22\2\2\2\u00a1\2\24\3\2\2\2"+
		"\4(\3\2\2\2\6P\3\2\2\2\bW\3\2\2\2\nY\3\2\2\2\f\\\3\2\2\2\16i\3\2\2\2\20"+
		"x\3\2\2\2\22\u0083\3\2\2\2\24\25\7\21\2\2\25\26\7\22\2\2\26\3\3\2\2\2"+
		"\27\31\7\16\2\2\30\27\3\2\2\2\31\32\3\2\2\2\32\30\3\2\2\2\32\33\3\2\2"+
		"\2\33)\3\2\2\2\34\36\7\3\2\2\35\37\7\17\2\2\36\35\3\2\2\2\37 \3\2\2\2"+
		" \36\3\2\2\2 !\3\2\2\2!)\3\2\2\2\"$\7\4\2\2#%\7\20\2\2$#\3\2\2\2%&\3\2"+
		"\2\2&$\3\2\2\2&\'\3\2\2\2\')\3\2\2\2(\30\3\2\2\2(\34\3\2\2\2(\"\3\2\2"+
		"\2)\5\3\2\2\2*,\7\16\2\2+*\3\2\2\2,/\3\2\2\2-+\3\2\2\2-.\3\2\2\2.\60\3"+
		"\2\2\2/-\3\2\2\2\60\62\7\5\2\2\61\63\7\16\2\2\62\61\3\2\2\2\63\64\3\2"+
		"\2\2\64\62\3\2\2\2\64\65\3\2\2\2\65Q\3\2\2\2\66:\7\3\2\2\679\7\17\2\2"+
		"8\67\3\2\2\29<\3\2\2\2:8\3\2\2\2:;\3\2\2\2;=\3\2\2\2<:\3\2\2\2=?\7\5\2"+
		"\2>@\7\17\2\2?>\3\2\2\2@A\3\2\2\2A?\3\2\2\2AB\3\2\2\2BQ\3\2\2\2CG\7\4"+
		"\2\2DF\7\20\2\2ED\3\2\2\2FI\3\2\2\2GE\3\2\2\2GH\3\2\2\2HJ\3\2\2\2IG\3"+
		"\2\2\2JL\7\5\2\2KM\7\20\2\2LK\3\2\2\2MN\3\2\2\2NL\3\2\2\2NO\3\2\2\2OQ"+
		"\3\2\2\2P-\3\2\2\2P\66\3\2\2\2PC\3\2\2\2Q\7\3\2\2\2RX\7\r\2\2SX\5\4\3"+
		"\2TX\5\6\4\2UX\7\22\2\2VX\5\f\7\2WR\3\2\2\2WS\3\2\2\2WT\3\2\2\2WU\3\2"+
		"\2\2WV\3\2\2\2X\t\3\2\2\2YZ\7\r\2\2Z[\7\6\2\2[\13\3\2\2\2\\^\7\7\2\2]"+
		"_\7\16\2\2^]\3\2\2\2_`\3\2\2\2`^\3\2\2\2`a\3\2\2\2a\r\3\2\2\2bf\5\n\6"+
		"\2ce\7\t\2\2dc\3\2\2\2eh\3\2\2\2fd\3\2\2\2fg\3\2\2\2gj\3\2\2\2hf\3\2\2"+
		"\2ib\3\2\2\2ij\3\2\2\2jk\3\2\2\2kt\7\f\2\2lq\5\b\5\2mn\7\b\2\2np\5\b\5"+
		"\2om\3\2\2\2ps\3\2\2\2qo\3\2\2\2qr\3\2\2\2ru\3\2\2\2sq\3\2\2\2tl\3\2\2"+
		"\2tu\3\2\2\2uv\3\2\2\2vw\7\t\2\2w\17\3\2\2\2xy\7\21\2\2y{\7\22\2\2z|\7"+
		"\t\2\2{z\3\2\2\2|}\3\2\2\2}{\3\2\2\2}~\3\2\2\2~\21\3\2\2\2\177\u0082\5"+
		"\20\t\2\u0080\u0082\7\t\2\2\u0081\177\3\2\2\2\u0081\u0080\3\2\2\2\u0082"+
		"\u0085\3\2\2\2\u0083\u0081\3\2\2\2\u0083\u0084\3\2\2\2\u0084\u008a\3\2"+
		"\2\2\u0085\u0083\3\2\2\2\u0086\u0089\5\16\b\2\u0087\u0089\7\t\2\2\u0088"+
		"\u0086\3\2\2\2\u0088\u0087\3\2\2\2\u0089\u008c\3\2\2\2\u008a\u0088\3\2"+
		"\2\2\u008a\u008b\3\2\2\2\u008b\u008d\3\2\2\2\u008c\u008a\3\2\2\2\u008d"+
		"\u008e\7\2\2\3\u008e\23\3\2\2\2\30\32 &(-\64:AGNPW`fiqt}\u0081\u0083\u0088"+
		"\u008a";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}