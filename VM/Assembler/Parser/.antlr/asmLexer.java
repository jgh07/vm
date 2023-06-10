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
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, NewLine=8, Ws=9, 
		Comment=10, OpCode=11, Include=12, Define=13, Identifier=14, DecimalDigit=15, 
		BinaryDigit=16, HexDigit=17, String=18, EscapeSequence=19;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	private static String[] makeRuleNames() {
		return new String[] {
			"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "NewLine", "Ws", 
			"Comment", "OpCode", "Include", "Define", "Identifier", "DecimalDigit", 
			"BinaryDigit", "HexDigit", "String", "EscapeSequence"
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
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2\25\u00d8\b\1\4\2"+
		"\t\2\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4"+
		"\13\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22"+
		"\t\22\4\23\t\23\4\24\t\24\3\2\3\2\3\3\3\3\3\3\3\4\3\4\3\4\3\5\3\5\3\6"+
		"\3\6\3\7\3\7\3\b\3\b\3\t\3\t\3\t\5\t=\n\t\3\n\6\n@\n\n\r\n\16\nA\3\n\3"+
		"\n\3\13\3\13\7\13H\n\13\f\13\16\13K\13\13\3\13\6\13N\n\13\r\13\16\13O"+
		"\3\13\3\13\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f"+
		"\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3"+
		"\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f"+
		"\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3"+
		"\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\5\f\u00a2\n\f\3\r\3\r\3\r\3"+
		"\r\3\r\3\r\3\r\3\r\3\16\3\16\3\16\3\16\3\16\3\16\3\16\3\17\5\17\u00b4"+
		"\n\17\3\17\7\17\u00b7\n\17\f\17\16\17\u00ba\13\17\3\20\3\20\3\21\3\21"+
		"\3\22\5\22\u00c1\n\22\3\23\3\23\3\23\7\23\u00c6\n\23\f\23\16\23\u00c9"+
		"\13\23\3\23\3\23\3\24\3\24\3\24\3\24\3\24\3\24\3\24\3\24\3\24\3\24\5\24"+
		"\u00d7\n\24\3I\2\25\3\3\5\4\7\5\t\6\13\7\r\b\17\t\21\n\23\13\25\f\27\r"+
		"\31\16\33\17\35\20\37\21!\22#\23%\24\'\25\3\2\n\6\2\f\f\17\17\u0087\u0087"+
		"\u202a\u202b\4\2\13\13\"\"\5\2C\\aac|\6\2\62;C\\aac|\3\2\62;\3\2\62\63"+
		"\5\2\62;CHch\b\2\f\f\17\17$$^^\u0087\u0087\u202a\u202b\2\u00fb\2\3\3\2"+
		"\2\2\2\5\3\2\2\2\2\7\3\2\2\2\2\t\3\2\2\2\2\13\3\2\2\2\2\r\3\2\2\2\2\17"+
		"\3\2\2\2\2\21\3\2\2\2\2\23\3\2\2\2\2\25\3\2\2\2\2\27\3\2\2\2\2\31\3\2"+
		"\2\2\2\33\3\2\2\2\2\35\3\2\2\2\2\37\3\2\2\2\2!\3\2\2\2\2#\3\2\2\2\2%\3"+
		"\2\2\2\2\'\3\2\2\2\3)\3\2\2\2\5+\3\2\2\2\7.\3\2\2\2\t\61\3\2\2\2\13\63"+
		"\3\2\2\2\r\65\3\2\2\2\17\67\3\2\2\2\21<\3\2\2\2\23?\3\2\2\2\25E\3\2\2"+
		"\2\27\u00a1\3\2\2\2\31\u00a3\3\2\2\2\33\u00ab\3\2\2\2\35\u00b3\3\2\2\2"+
		"\37\u00bb\3\2\2\2!\u00bd\3\2\2\2#\u00c0\3\2\2\2%\u00c2\3\2\2\2\'\u00d6"+
		"\3\2\2\2)*\7&\2\2*\4\3\2\2\2+,\7\62\2\2,-\7d\2\2-\6\3\2\2\2./\7\62\2\2"+
		"/\60\7z\2\2\60\b\3\2\2\2\61\62\7\60\2\2\62\n\3\2\2\2\63\64\7<\2\2\64\f"+
		"\3\2\2\2\65\66\7\'\2\2\66\16\3\2\2\2\678\7.\2\28\20\3\2\2\29:\7\17\2\2"+
		":=\7\f\2\2;=\t\2\2\2<9\3\2\2\2<;\3\2\2\2=\22\3\2\2\2>@\t\3\2\2?>\3\2\2"+
		"\2@A\3\2\2\2A?\3\2\2\2AB\3\2\2\2BC\3\2\2\2CD\b\n\2\2D\24\3\2\2\2EI\7="+
		"\2\2FH\13\2\2\2GF\3\2\2\2HK\3\2\2\2IJ\3\2\2\2IG\3\2\2\2JM\3\2\2\2KI\3"+
		"\2\2\2LN\5\21\t\2ML\3\2\2\2NO\3\2\2\2OM\3\2\2\2OP\3\2\2\2PQ\3\2\2\2QR"+
		"\b\13\2\2R\26\3\2\2\2ST\7P\2\2TU\7Q\2\2U\u00a2\7R\2\2VW\7T\2\2WX\7G\2"+
		"\2X\u00a2\7V\2\2YZ\7J\2\2Z[\7N\2\2[\u00a2\7V\2\2\\]\7C\2\2]^\7F\2\2^\u00a2"+
		"\7F\2\2_`\7U\2\2`a\7W\2\2a\u00a2\7D\2\2bc\7O\2\2cd\7W\2\2d\u00a2\7N\2"+
		"\2ef\7F\2\2fg\7K\2\2g\u00a2\7X\2\2hi\7U\2\2ij\7J\2\2j\u00a2\7N\2\2kl\7"+
		"U\2\2lm\7J\2\2m\u00a2\7T\2\2no\7L\2\2op\7O\2\2p\u00a2\7R\2\2qr\7D\2\2"+
		"rs\7G\2\2s\u00a2\7S\2\2tu\7P\2\2uv\7Q\2\2v\u00a2\7V\2\2wx\7C\2\2xy\7P"+
		"\2\2y\u00a2\7F\2\2z{\7Q\2\2{\u00a2\7T\2\2|}\7E\2\2}~\7G\2\2~\u00a2\7S"+
		"\2\2\177\u0080\7E\2\2\u0080\u0081\7I\2\2\u0081\u00a2\7V\2\2\u0082\u0083"+
		"\7E\2\2\u0083\u0084\7N\2\2\u0084\u00a2\7V\2\2\u0085\u0086\7Z\2\2\u0086"+
		"\u0087\7Q\2\2\u0087\u00a2\7T\2\2\u0088\u0089\7U\2\2\u0089\u008a\7V\2\2"+
		"\u008a\u00a2\7T\2\2\u008b\u008c\7T\2\2\u008c\u008d\7G\2\2\u008d\u00a2"+
		"\7O\2\2\u008e\u008f\7E\2\2\u008f\u0090\7P\2\2\u0090\u00a2\7X\2\2\u0091"+
		"\u0092\7U\2\2\u0092\u0093\7Y\2\2\u0093\u00a2\7R\2\2\u0094\u0095\7E\2\2"+
		"\u0095\u0096\7C\2\2\u0096\u0097\7N\2\2\u0097\u00a2\7N\2\2\u0098\u0099"+
		"\7T\2\2\u0099\u009a\7V\2\2\u009a\u00a2\7E\2\2\u009b\u009c\7F\2\2\u009c"+
		"\u009d\7H\2\2\u009d\u00a2\7E\2\2\u009e\u009f\7K\2\2\u009f\u00a0\7P\2\2"+
		"\u00a0\u00a2\7V\2\2\u00a1S\3\2\2\2\u00a1V\3\2\2\2\u00a1Y\3\2\2\2\u00a1"+
		"\\\3\2\2\2\u00a1_\3\2\2\2\u00a1b\3\2\2\2\u00a1e\3\2\2\2\u00a1h\3\2\2\2"+
		"\u00a1k\3\2\2\2\u00a1n\3\2\2\2\u00a1q\3\2\2\2\u00a1t\3\2\2\2\u00a1w\3"+
		"\2\2\2\u00a1z\3\2\2\2\u00a1|\3\2\2\2\u00a1\177\3\2\2\2\u00a1\u0082\3\2"+
		"\2\2\u00a1\u0085\3\2\2\2\u00a1\u0088\3\2\2\2\u00a1\u008b\3\2\2\2\u00a1"+
		"\u008e\3\2\2\2\u00a1\u0091\3\2\2\2\u00a1\u0094\3\2\2\2\u00a1\u0098\3\2"+
		"\2\2\u00a1\u009b\3\2\2\2\u00a1\u009e\3\2\2\2\u00a2\30\3\2\2\2\u00a3\u00a4"+
		"\7k\2\2\u00a4\u00a5\7p\2\2\u00a5\u00a6\7e\2\2\u00a6\u00a7\7n\2\2\u00a7"+
		"\u00a8\7w\2\2\u00a8\u00a9\7f\2\2\u00a9\u00aa\7g\2\2\u00aa\32\3\2\2\2\u00ab"+
		"\u00ac\7f\2\2\u00ac\u00ad\7g\2\2\u00ad\u00ae\7h\2\2\u00ae\u00af\7k\2\2"+
		"\u00af\u00b0\7p\2\2\u00b0\u00b1\7g\2\2\u00b1\34\3\2\2\2\u00b2\u00b4\t"+
		"\4\2\2\u00b3\u00b2\3\2\2\2\u00b4\u00b8\3\2\2\2\u00b5\u00b7\t\5\2\2\u00b6"+
		"\u00b5\3\2\2\2\u00b7\u00ba\3\2\2\2\u00b8\u00b6\3\2\2\2\u00b8\u00b9\3\2"+
		"\2\2\u00b9\36\3\2\2\2\u00ba\u00b8\3\2\2\2\u00bb\u00bc\t\6\2\2\u00bc \3"+
		"\2\2\2\u00bd\u00be\t\7\2\2\u00be\"\3\2\2\2\u00bf\u00c1\t\b\2\2\u00c0\u00bf"+
		"\3\2\2\2\u00c1$\3\2\2\2\u00c2\u00c7\7$\2\2\u00c3\u00c6\n\t\2\2\u00c4\u00c6"+
		"\5\'\24\2\u00c5\u00c3\3\2\2\2\u00c5\u00c4\3\2\2\2\u00c6\u00c9\3\2\2\2"+
		"\u00c7\u00c5\3\2\2\2\u00c7\u00c8\3\2\2\2\u00c8\u00ca\3\2\2\2\u00c9\u00c7"+
		"\3\2\2\2\u00ca\u00cb\7$\2\2\u00cb&\3\2\2\2\u00cc\u00cd\7^\2\2\u00cd\u00d7"+
		"\7^\2\2\u00ce\u00cf\7^\2\2\u00cf\u00d7\7t\2\2\u00d0\u00d1\7^\2\2\u00d1"+
		"\u00d7\7p\2\2\u00d2\u00d3\7^\2\2\u00d3\u00d7\7$\2\2\u00d4\u00d5\7^\2\2"+
		"\u00d5\u00d7\7d\2\2\u00d6\u00cc\3\2\2\2\u00d6\u00ce\3\2\2\2\u00d6\u00d0"+
		"\3\2\2\2\u00d6\u00d2\3\2\2\2\u00d6\u00d4\3\2\2\2\u00d7(\3\2\2\2\17\2<"+
		"AIO\u00a1\u00b3\u00b6\u00b8\u00c0\u00c5\u00c7\u00d6\3\b\2\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}