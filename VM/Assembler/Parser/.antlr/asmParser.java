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
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, NewLine=8, Ws=9, 
		Comment=10, OpCode=11, Include=12, Define=13, Identifier=14, DecimalDigit=15, 
		BinaryDigit=16, HexDigit=17, String=18, EscapeSequence=19;
	public static final int
		RULE_global_include = 0, RULE_constant_definition = 1, RULE_constant = 2, 
		RULE_integer = 3, RULE_floating_point_number = 4, RULE_operand = 5, RULE_label = 6, 
		RULE_line_number = 7, RULE_instruction = 8, RULE_include = 9, RULE_compilation_unit = 10;
	private static String[] makeRuleNames() {
		return new String[] {
			"global_include", "constant_definition", "constant", "integer", "floating_point_number", 
			"operand", "label", "line_number", "instruction", "include", "compilation_unit"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "'$'", "'0b'", "'0x'", "'.'", "':'", "'%'", "','", null, null, 
			null, null, "'include'", "'define'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, null, null, null, null, null, null, null, "NewLine", "Ws", "Comment", 
			"OpCode", "Include", "Define", "Identifier", "DecimalDigit", "BinaryDigit", 
			"HexDigit", "String", "EscapeSequence"
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
			setState(22);
			match(Include);
			setState(23);
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

	public static class Constant_definitionContext extends ParserRuleContext {
		public TerminalNode Define() { return getToken(asmParser.Define, 0); }
		public ConstantContext constant() {
			return getRuleContext(ConstantContext.class,0);
		}
		public OperandContext operand() {
			return getRuleContext(OperandContext.class,0);
		}
		public Constant_definitionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_constant_definition; }
	}

	public final Constant_definitionContext constant_definition() throws RecognitionException {
		Constant_definitionContext _localctx = new Constant_definitionContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_constant_definition);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(25);
			match(Define);
			setState(26);
			constant();
			setState(27);
			operand();
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

	public static class ConstantContext extends ParserRuleContext {
		public TerminalNode Identifier() { return getToken(asmParser.Identifier, 0); }
		public ConstantContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_constant; }
	}

	public final ConstantContext constant() throws RecognitionException {
		ConstantContext _localctx = new ConstantContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_constant);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(29);
			match(T__0);
			setState(30);
			match(Identifier);
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
		enterRule(_localctx, 6, RULE_integer);
		int _la;
		try {
			setState(49);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case DecimalDigit:
				_localctx = new Decimal_literalContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(33); 
				_errHandler.sync(this);
				_la = _input.LA(1);
				do {
					{
					{
					setState(32);
					match(DecimalDigit);
					}
					}
					setState(35); 
					_errHandler.sync(this);
					_la = _input.LA(1);
				} while ( _la==DecimalDigit );
				}
				break;
			case T__1:
				_localctx = new Binary_literalContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(37);
				match(T__1);
				setState(39); 
				_errHandler.sync(this);
				_la = _input.LA(1);
				do {
					{
					{
					setState(38);
					match(BinaryDigit);
					}
					}
					setState(41); 
					_errHandler.sync(this);
					_la = _input.LA(1);
				} while ( _la==BinaryDigit );
				}
				break;
			case T__2:
				_localctx = new Hex_literalContext(_localctx);
				enterOuterAlt(_localctx, 3);
				{
				setState(43);
				match(T__2);
				setState(45); 
				_errHandler.sync(this);
				_la = _input.LA(1);
				do {
					{
					{
					setState(44);
					match(HexDigit);
					}
					}
					setState(47); 
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
		enterRule(_localctx, 8, RULE_floating_point_number);
		int _la;
		try {
			setState(89);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case T__3:
			case DecimalDigit:
				_localctx = new Decimal_floatContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(54);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while (_la==DecimalDigit) {
					{
					{
					setState(51);
					match(DecimalDigit);
					}
					}
					setState(56);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				setState(57);
				match(T__3);
				setState(59); 
				_errHandler.sync(this);
				_la = _input.LA(1);
				do {
					{
					{
					setState(58);
					match(DecimalDigit);
					}
					}
					setState(61); 
					_errHandler.sync(this);
					_la = _input.LA(1);
				} while ( _la==DecimalDigit );
				}
				break;
			case T__1:
				_localctx = new Binary_floatContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(63);
				match(T__1);
				setState(67);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while (_la==BinaryDigit) {
					{
					{
					setState(64);
					match(BinaryDigit);
					}
					}
					setState(69);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				setState(70);
				match(T__3);
				setState(72); 
				_errHandler.sync(this);
				_la = _input.LA(1);
				do {
					{
					{
					setState(71);
					match(BinaryDigit);
					}
					}
					setState(74); 
					_errHandler.sync(this);
					_la = _input.LA(1);
				} while ( _la==BinaryDigit );
				}
				break;
			case T__2:
				_localctx = new Hex_floatContext(_localctx);
				enterOuterAlt(_localctx, 3);
				{
				setState(76);
				match(T__2);
				setState(80);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while (_la==HexDigit) {
					{
					{
					setState(77);
					match(HexDigit);
					}
					}
					setState(82);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				setState(83);
				match(T__3);
				setState(85); 
				_errHandler.sync(this);
				_la = _input.LA(1);
				do {
					{
					{
					setState(84);
					match(HexDigit);
					}
					}
					setState(87); 
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
		public ConstantContext constant() {
			return getRuleContext(ConstantContext.class,0);
		}
		public OperandContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_operand; }
	}

	public final OperandContext operand() throws RecognitionException {
		OperandContext _localctx = new OperandContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_operand);
		try {
			setState(97);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,11,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(91);
				match(Identifier);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(92);
				integer();
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(93);
				floating_point_number();
				}
				break;
			case 4:
				enterOuterAlt(_localctx, 4);
				{
				setState(94);
				match(String);
				}
				break;
			case 5:
				enterOuterAlt(_localctx, 5);
				{
				setState(95);
				line_number();
				}
				break;
			case 6:
				enterOuterAlt(_localctx, 6);
				{
				setState(96);
				constant();
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
		enterRule(_localctx, 12, RULE_label);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(99);
			match(Identifier);
			setState(100);
			match(T__4);
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
		enterRule(_localctx, 14, RULE_line_number);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(102);
			match(T__5);
			setState(104); 
			_errHandler.sync(this);
			_la = _input.LA(1);
			do {
				{
				{
				setState(103);
				match(DecimalDigit);
				}
				}
				setState(106); 
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
		enterRule(_localctx, 16, RULE_instruction);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(115);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==Identifier) {
				{
				setState(108);
				label();
				setState(112);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while (_la==NewLine) {
					{
					{
					setState(109);
					match(NewLine);
					}
					}
					setState(114);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				}
			}

			setState(117);
			match(OpCode);
			setState(126);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__5) | (1L << Identifier) | (1L << DecimalDigit) | (1L << String))) != 0)) {
				{
				setState(118);
				operand();
				setState(123);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while (_la==T__6) {
					{
					{
					setState(119);
					match(T__6);
					setState(120);
					operand();
					}
					}
					setState(125);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				}
			}

			setState(128);
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
		enterRule(_localctx, 18, RULE_include);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(130);
			match(Include);
			setState(131);
			match(String);
			setState(133); 
			_errHandler.sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					setState(132);
					match(NewLine);
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				setState(135); 
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
		public List<Constant_definitionContext> constant_definition() {
			return getRuleContexts(Constant_definitionContext.class);
		}
		public Constant_definitionContext constant_definition(int i) {
			return getRuleContext(Constant_definitionContext.class,i);
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
		enterRule(_localctx, 20, RULE_compilation_unit);
		int _la;
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(142);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,19,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					setState(140);
					_errHandler.sync(this);
					switch (_input.LA(1)) {
					case Include:
						{
						setState(137);
						include();
						}
						break;
					case Define:
						{
						setState(138);
						constant_definition();
						}
						break;
					case NewLine:
						{
						setState(139);
						match(NewLine);
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					} 
				}
				setState(144);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,19,_ctx);
			}
			setState(149);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << NewLine) | (1L << OpCode) | (1L << Identifier))) != 0)) {
				{
				setState(147);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case OpCode:
				case Identifier:
					{
					setState(145);
					instruction();
					}
					break;
				case NewLine:
					{
					setState(146);
					match(NewLine);
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				setState(151);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(152);
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
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3\25\u009d\4\2\t\2"+
		"\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13"+
		"\t\13\4\f\t\f\3\2\3\2\3\2\3\3\3\3\3\3\3\3\3\4\3\4\3\4\3\5\6\5$\n\5\r\5"+
		"\16\5%\3\5\3\5\6\5*\n\5\r\5\16\5+\3\5\3\5\6\5\60\n\5\r\5\16\5\61\5\5\64"+
		"\n\5\3\6\7\6\67\n\6\f\6\16\6:\13\6\3\6\3\6\6\6>\n\6\r\6\16\6?\3\6\3\6"+
		"\7\6D\n\6\f\6\16\6G\13\6\3\6\3\6\6\6K\n\6\r\6\16\6L\3\6\3\6\7\6Q\n\6\f"+
		"\6\16\6T\13\6\3\6\3\6\6\6X\n\6\r\6\16\6Y\5\6\\\n\6\3\7\3\7\3\7\3\7\3\7"+
		"\3\7\5\7d\n\7\3\b\3\b\3\b\3\t\3\t\6\tk\n\t\r\t\16\tl\3\n\3\n\7\nq\n\n"+
		"\f\n\16\nt\13\n\5\nv\n\n\3\n\3\n\3\n\3\n\7\n|\n\n\f\n\16\n\177\13\n\5"+
		"\n\u0081\n\n\3\n\3\n\3\13\3\13\3\13\6\13\u0088\n\13\r\13\16\13\u0089\3"+
		"\f\3\f\3\f\7\f\u008f\n\f\f\f\16\f\u0092\13\f\3\f\3\f\7\f\u0096\n\f\f\f"+
		"\16\f\u0099\13\f\3\f\3\f\3\f\2\2\r\2\4\6\b\n\f\16\20\22\24\26\2\2\2\u00ae"+
		"\2\30\3\2\2\2\4\33\3\2\2\2\6\37\3\2\2\2\b\63\3\2\2\2\n[\3\2\2\2\fc\3\2"+
		"\2\2\16e\3\2\2\2\20h\3\2\2\2\22u\3\2\2\2\24\u0084\3\2\2\2\26\u0090\3\2"+
		"\2\2\30\31\7\16\2\2\31\32\7\24\2\2\32\3\3\2\2\2\33\34\7\17\2\2\34\35\5"+
		"\6\4\2\35\36\5\f\7\2\36\5\3\2\2\2\37 \7\3\2\2 !\7\20\2\2!\7\3\2\2\2\""+
		"$\7\21\2\2#\"\3\2\2\2$%\3\2\2\2%#\3\2\2\2%&\3\2\2\2&\64\3\2\2\2\')\7\4"+
		"\2\2(*\7\22\2\2)(\3\2\2\2*+\3\2\2\2+)\3\2\2\2+,\3\2\2\2,\64\3\2\2\2-/"+
		"\7\5\2\2.\60\7\23\2\2/.\3\2\2\2\60\61\3\2\2\2\61/\3\2\2\2\61\62\3\2\2"+
		"\2\62\64\3\2\2\2\63#\3\2\2\2\63\'\3\2\2\2\63-\3\2\2\2\64\t\3\2\2\2\65"+
		"\67\7\21\2\2\66\65\3\2\2\2\67:\3\2\2\28\66\3\2\2\289\3\2\2\29;\3\2\2\2"+
		":8\3\2\2\2;=\7\6\2\2<>\7\21\2\2=<\3\2\2\2>?\3\2\2\2?=\3\2\2\2?@\3\2\2"+
		"\2@\\\3\2\2\2AE\7\4\2\2BD\7\22\2\2CB\3\2\2\2DG\3\2\2\2EC\3\2\2\2EF\3\2"+
		"\2\2FH\3\2\2\2GE\3\2\2\2HJ\7\6\2\2IK\7\22\2\2JI\3\2\2\2KL\3\2\2\2LJ\3"+
		"\2\2\2LM\3\2\2\2M\\\3\2\2\2NR\7\5\2\2OQ\7\23\2\2PO\3\2\2\2QT\3\2\2\2R"+
		"P\3\2\2\2RS\3\2\2\2SU\3\2\2\2TR\3\2\2\2UW\7\6\2\2VX\7\23\2\2WV\3\2\2\2"+
		"XY\3\2\2\2YW\3\2\2\2YZ\3\2\2\2Z\\\3\2\2\2[8\3\2\2\2[A\3\2\2\2[N\3\2\2"+
		"\2\\\13\3\2\2\2]d\7\20\2\2^d\5\b\5\2_d\5\n\6\2`d\7\24\2\2ad\5\20\t\2b"+
		"d\5\6\4\2c]\3\2\2\2c^\3\2\2\2c_\3\2\2\2c`\3\2\2\2ca\3\2\2\2cb\3\2\2\2"+
		"d\r\3\2\2\2ef\7\20\2\2fg\7\7\2\2g\17\3\2\2\2hj\7\b\2\2ik\7\21\2\2ji\3"+
		"\2\2\2kl\3\2\2\2lj\3\2\2\2lm\3\2\2\2m\21\3\2\2\2nr\5\16\b\2oq\7\n\2\2"+
		"po\3\2\2\2qt\3\2\2\2rp\3\2\2\2rs\3\2\2\2sv\3\2\2\2tr\3\2\2\2un\3\2\2\2"+
		"uv\3\2\2\2vw\3\2\2\2w\u0080\7\r\2\2x}\5\f\7\2yz\7\t\2\2z|\5\f\7\2{y\3"+
		"\2\2\2|\177\3\2\2\2}{\3\2\2\2}~\3\2\2\2~\u0081\3\2\2\2\177}\3\2\2\2\u0080"+
		"x\3\2\2\2\u0080\u0081\3\2\2\2\u0081\u0082\3\2\2\2\u0082\u0083\7\n\2\2"+
		"\u0083\23\3\2\2\2\u0084\u0085\7\16\2\2\u0085\u0087\7\24\2\2\u0086\u0088"+
		"\7\n\2\2\u0087\u0086\3\2\2\2\u0088\u0089\3\2\2\2\u0089\u0087\3\2\2\2\u0089"+
		"\u008a\3\2\2\2\u008a\25\3\2\2\2\u008b\u008f\5\24\13\2\u008c\u008f\5\4"+
		"\3\2\u008d\u008f\7\n\2\2\u008e\u008b\3\2\2\2\u008e\u008c\3\2\2\2\u008e"+
		"\u008d\3\2\2\2\u008f\u0092\3\2\2\2\u0090\u008e\3\2\2\2\u0090\u0091\3\2"+
		"\2\2\u0091\u0097\3\2\2\2\u0092\u0090\3\2\2\2\u0093\u0096\5\22\n\2\u0094"+
		"\u0096\7\n\2\2\u0095\u0093\3\2\2\2\u0095\u0094\3\2\2\2\u0096\u0099\3\2"+
		"\2\2\u0097\u0095\3\2\2\2\u0097\u0098\3\2\2\2\u0098\u009a\3\2\2\2\u0099"+
		"\u0097\3\2\2\2\u009a\u009b\7\2\2\3\u009b\27\3\2\2\2\30%+\61\638?ELRY["+
		"clru}\u0080\u0089\u008e\u0090\u0095\u0097";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}