// Generated from c:\Users\Jonas\source\repos\VM\VM\Assembler\Parser\asm.g4 by ANTLR 4.9.2
import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class asmLexer extends Lexer {
	static { RuntimeMetaData.checkVersion("4.9.2", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, NewLine=7, Ws=8, Comment=9, 
		OpCode=10, Identifier=11, DecimalDigit=12, BinaryDigit=13, HexDigit=14, 
		Include=15, String=16, EscapeSequence=17;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	private static String[] makeRuleNames() {
		return new String[] {
			"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "NewLine", "Ws", "Comment", 
			"OpCode", "Identifier", "DecimalDigit", "BinaryDigit", "HexDigit", "Include", 
			"String", "EscapeSequence"
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


	public asmLexer(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "asm.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public String[] getChannelNames() { return channelNames; }

	@Override
	public String[] getModeNames() { return modeNames; }

	@Override
	public ATN getATN() { return _ATN; }

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2\23\u00c3\b\1\4\2"+
		"\t\2\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4"+
		"\13\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22"+
		"\t\22\3\2\3\2\3\2\3\3\3\3\3\3\3\4\3\4\3\5\3\5\3\6\3\6\3\7\3\7\3\b\3\b"+
		"\3\b\5\b\67\n\b\3\t\6\t:\n\t\r\t\16\t;\3\t\3\t\3\n\3\n\7\nB\n\n\f\n\16"+
		"\nE\13\n\3\n\6\nH\n\n\r\n\16\nI\3\n\3\n\3\13\3\13\3\13\3\13\3\13\3\13"+
		"\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13"+
		"\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13"+
		"\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13"+
		"\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13"+
		"\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\5\13\u0096\n\13\3\f"+
		"\5\f\u0099\n\f\3\f\7\f\u009c\n\f\f\f\16\f\u009f\13\f\3\r\3\r\3\16\3\16"+
		"\3\17\5\17\u00a6\n\17\3\20\3\20\3\20\3\20\3\20\3\20\3\20\3\20\3\21\3\21"+
		"\3\21\7\21\u00b3\n\21\f\21\16\21\u00b6\13\21\3\21\3\21\3\22\3\22\3\22"+
		"\3\22\3\22\3\22\3\22\3\22\5\22\u00c2\n\22\3C\2\23\3\3\5\4\7\5\t\6\13\7"+
		"\r\b\17\t\21\n\23\13\25\f\27\r\31\16\33\17\35\20\37\21!\22#\23\3\2\n\6"+
		"\2\f\f\17\17\u0087\u0087\u202a\u202b\4\2\13\13\"\"\5\2C\\aac|\6\2\62;"+
		"C\\aac|\3\2\62;\3\2\62\63\5\2\62;CHch\b\2\f\f\17\17$$^^\u0087\u0087\u202a"+
		"\u202b\2\u00e3\2\3\3\2\2\2\2\5\3\2\2\2\2\7\3\2\2\2\2\t\3\2\2\2\2\13\3"+
		"\2\2\2\2\r\3\2\2\2\2\17\3\2\2\2\2\21\3\2\2\2\2\23\3\2\2\2\2\25\3\2\2\2"+
		"\2\27\3\2\2\2\2\31\3\2\2\2\2\33\3\2\2\2\2\35\3\2\2\2\2\37\3\2\2\2\2!\3"+
		"\2\2\2\2#\3\2\2\2\3%\3\2\2\2\5(\3\2\2\2\7+\3\2\2\2\t-\3\2\2\2\13/\3\2"+
		"\2\2\r\61\3\2\2\2\17\66\3\2\2\2\219\3\2\2\2\23?\3\2\2\2\25\u0095\3\2\2"+
		"\2\27\u0098\3\2\2\2\31\u00a0\3\2\2\2\33\u00a2\3\2\2\2\35\u00a5\3\2\2\2"+
		"\37\u00a7\3\2\2\2!\u00af\3\2\2\2#\u00c1\3\2\2\2%&\7\62\2\2&\'\7d\2\2\'"+
		"\4\3\2\2\2()\7\62\2\2)*\7z\2\2*\6\3\2\2\2+,\7\60\2\2,\b\3\2\2\2-.\7<\2"+
		"\2.\n\3\2\2\2/\60\7\'\2\2\60\f\3\2\2\2\61\62\7.\2\2\62\16\3\2\2\2\63\64"+
		"\7\17\2\2\64\67\7\f\2\2\65\67\t\2\2\2\66\63\3\2\2\2\66\65\3\2\2\2\67\20"+
		"\3\2\2\28:\t\3\2\298\3\2\2\2:;\3\2\2\2;9\3\2\2\2;<\3\2\2\2<=\3\2\2\2="+
		">\b\t\2\2>\22\3\2\2\2?C\7=\2\2@B\13\2\2\2A@\3\2\2\2BE\3\2\2\2CD\3\2\2"+
		"\2CA\3\2\2\2DG\3\2\2\2EC\3\2\2\2FH\5\17\b\2GF\3\2\2\2HI\3\2\2\2IG\3\2"+
		"\2\2IJ\3\2\2\2JK\3\2\2\2KL\b\n\2\2L\24\3\2\2\2MN\7P\2\2NO\7Q\2\2O\u0096"+
		"\7R\2\2PQ\7T\2\2QR\7G\2\2R\u0096\7V\2\2ST\7J\2\2TU\7N\2\2U\u0096\7V\2"+
		"\2VW\7C\2\2WX\7F\2\2X\u0096\7F\2\2YZ\7U\2\2Z[\7W\2\2[\u0096\7D\2\2\\]"+
		"\7O\2\2]^\7W\2\2^\u0096\7N\2\2_`\7F\2\2`a\7K\2\2a\u0096\7X\2\2bc\7U\2"+
		"\2cd\7J\2\2d\u0096\7N\2\2ef\7U\2\2fg\7J\2\2g\u0096\7T\2\2hi\7L\2\2ij\7"+
		"O\2\2j\u0096\7R\2\2kl\7D\2\2lm\7G\2\2m\u0096\7S\2\2no\7P\2\2op\7Q\2\2"+
		"p\u0096\7V\2\2qr\7C\2\2rs\7P\2\2s\u0096\7F\2\2tu\7Q\2\2u\u0096\7T\2\2"+
		"vw\7E\2\2wx\7G\2\2x\u0096\7S\2\2yz\7Z\2\2z{\7Q\2\2{\u0096\7T\2\2|}\7U"+
		"\2\2}~\7V\2\2~\u0096\7T\2\2\177\u0080\7T\2\2\u0080\u0081\7G\2\2\u0081"+
		"\u0096\7O\2\2\u0082\u0083\7E\2\2\u0083\u0084\7P\2\2\u0084\u0096\7X\2\2"+
		"\u0085\u0086\7U\2\2\u0086\u0087\7Y\2\2\u0087\u0096\7R\2\2\u0088\u0089"+
		"\7E\2\2\u0089\u008a\7C\2\2\u008a\u008b\7N\2\2\u008b\u0096\7N\2\2\u008c"+
		"\u008d\7T\2\2\u008d\u008e\7V\2\2\u008e\u0096\7E\2\2\u008f\u0090\7F\2\2"+
		"\u0090\u0091\7H\2\2\u0091\u0096\7E\2\2\u0092\u0093\7K\2\2\u0093\u0094"+
		"\7P\2\2\u0094\u0096\7V\2\2\u0095M\3\2\2\2\u0095P\3\2\2\2\u0095S\3\2\2"+
		"\2\u0095V\3\2\2\2\u0095Y\3\2\2\2\u0095\\\3\2\2\2\u0095_\3\2\2\2\u0095"+
		"b\3\2\2\2\u0095e\3\2\2\2\u0095h\3\2\2\2\u0095k\3\2\2\2\u0095n\3\2\2\2"+
		"\u0095q\3\2\2\2\u0095t\3\2\2\2\u0095v\3\2\2\2\u0095y\3\2\2\2\u0095|\3"+
		"\2\2\2\u0095\177\3\2\2\2\u0095\u0082\3\2\2\2\u0095\u0085\3\2\2\2\u0095"+
		"\u0088\3\2\2\2\u0095\u008c\3\2\2\2\u0095\u008f\3\2\2\2\u0095\u0092\3\2"+
		"\2\2\u0096\26\3\2\2\2\u0097\u0099\t\4\2\2\u0098\u0097\3\2\2\2\u0099\u009d"+
		"\3\2\2\2\u009a\u009c\t\5\2\2\u009b\u009a\3\2\2\2\u009c\u009f\3\2\2\2\u009d"+
		"\u009b\3\2\2\2\u009d\u009e\3\2\2\2\u009e\30\3\2\2\2\u009f\u009d\3\2\2"+
		"\2\u00a0\u00a1\t\6\2\2\u00a1\32\3\2\2\2\u00a2\u00a3\t\7\2\2\u00a3\34\3"+
		"\2\2\2\u00a4\u00a6\t\b\2\2\u00a5\u00a4\3\2\2\2\u00a6\36\3\2\2\2\u00a7"+
		"\u00a8\7K\2\2\u00a8\u00a9\7P\2\2\u00a9\u00aa\7E\2\2\u00aa\u00ab\7N\2\2"+
		"\u00ab\u00ac\7W\2\2\u00ac\u00ad\7F\2\2\u00ad\u00ae\7G\2\2\u00ae \3\2\2"+
		"\2\u00af\u00b4\7$\2\2\u00b0\u00b3\n\t\2\2\u00b1\u00b3\5#\22\2\u00b2\u00b0"+
		"\3\2\2\2\u00b2\u00b1\3\2\2\2\u00b3\u00b6\3\2\2\2\u00b4\u00b2\3\2\2\2\u00b4"+
		"\u00b5\3\2\2\2\u00b5\u00b7\3\2\2\2\u00b6\u00b4\3\2\2\2\u00b7\u00b8\7$"+
		"\2\2\u00b8\"\3\2\2\2\u00b9\u00ba\7^\2\2\u00ba\u00c2\7^\2\2\u00bb\u00bc"+
		"\7^\2\2\u00bc\u00c2\7t\2\2\u00bd\u00be\7^\2\2\u00be\u00c2\7p\2\2\u00bf"+
		"\u00c0\7^\2\2\u00c0\u00c2\7$\2\2\u00c1\u00b9\3\2\2\2\u00c1\u00bb\3\2\2"+
		"\2\u00c1\u00bd\3\2\2\2\u00c1\u00bf\3\2\2\2\u00c2$\3\2\2\2\17\2\66;CI\u0095"+
		"\u0098\u009b\u009d\u00a5\u00b2\u00b4\u00c1\3\b\2\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}