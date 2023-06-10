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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.CLSCompliant(false)]
public partial class asmLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, NewLine=7, Ws=8, Comment=9, 
		OpCode=10, Identifier=11, DecimalDigit=12, BinaryDigit=13, HexDigit=14, 
		Include=15, String=16, EscapeSequence=17;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "NewLine", "Ws", "Comment", 
		"OpCode", "Identifier", "DecimalDigit", "BinaryDigit", "HexDigit", "Include", 
		"String", "EscapeSequence"
	};


	public asmLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public asmLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

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

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static asmLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,17,201,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,1,0,1,0,1,0,1,1,1,1,1,1,1,2,1,2,1,3,1,3,1,4,1,
		4,1,5,1,5,1,6,1,6,1,6,3,6,53,8,6,1,7,4,7,56,8,7,11,7,12,7,57,1,7,1,7,1,
		8,1,8,5,8,64,8,8,10,8,12,8,67,9,8,1,8,4,8,70,8,8,11,8,12,8,71,1,8,1,8,
		1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,
		9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,
		1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,
		9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,
		1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,3,9,154,8,9,1,10,3,10,157,8,10,1,10,5,
		10,160,8,10,10,10,12,10,163,9,10,1,11,1,11,1,12,1,12,1,13,3,13,170,8,13,
		1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,15,1,15,1,15,5,15,183,8,15,10,
		15,12,15,186,9,15,1,15,1,15,1,16,1,16,1,16,1,16,1,16,1,16,1,16,1,16,1,
		16,1,16,3,16,200,8,16,1,65,0,17,1,1,3,2,5,3,7,4,9,5,11,6,13,7,15,8,17,
		9,19,10,21,11,23,12,25,13,27,14,29,15,31,16,33,17,1,0,31,2,0,66,66,98,
		98,2,0,88,88,120,120,4,0,10,10,13,13,133,133,8232,8233,2,0,9,9,32,32,2,
		0,78,78,110,110,2,0,79,79,111,111,2,0,80,80,112,112,2,0,82,82,114,114,
		2,0,69,69,101,101,2,0,84,84,116,116,2,0,72,72,104,104,2,0,76,76,108,108,
		2,0,65,65,97,97,2,0,68,68,100,100,2,0,83,83,115,115,2,0,85,85,117,117,
		2,0,77,77,109,109,2,0,73,73,105,105,2,0,86,86,118,118,2,0,74,74,106,106,
		2,0,81,81,113,113,2,0,67,67,99,99,2,0,71,71,103,103,2,0,87,87,119,119,
		2,0,70,70,102,102,3,0,65,90,95,95,97,122,4,0,48,57,65,90,95,95,97,122,
		1,0,48,57,1,0,48,49,3,0,48,57,65,70,97,102,6,0,10,10,13,13,34,34,92,92,
		133,133,8232,8233,236,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,
		0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,
		0,0,0,0,21,1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,
		0,31,1,0,0,0,0,33,1,0,0,0,1,35,1,0,0,0,3,38,1,0,0,0,5,41,1,0,0,0,7,43,
		1,0,0,0,9,45,1,0,0,0,11,47,1,0,0,0,13,52,1,0,0,0,15,55,1,0,0,0,17,61,1,
		0,0,0,19,153,1,0,0,0,21,156,1,0,0,0,23,164,1,0,0,0,25,166,1,0,0,0,27,169,
		1,0,0,0,29,171,1,0,0,0,31,179,1,0,0,0,33,199,1,0,0,0,35,36,5,48,0,0,36,
		37,7,0,0,0,37,2,1,0,0,0,38,39,5,48,0,0,39,40,7,1,0,0,40,4,1,0,0,0,41,42,
		5,46,0,0,42,6,1,0,0,0,43,44,5,58,0,0,44,8,1,0,0,0,45,46,5,37,0,0,46,10,
		1,0,0,0,47,48,5,44,0,0,48,12,1,0,0,0,49,50,5,13,0,0,50,53,5,10,0,0,51,
		53,7,2,0,0,52,49,1,0,0,0,52,51,1,0,0,0,53,14,1,0,0,0,54,56,7,3,0,0,55,
		54,1,0,0,0,56,57,1,0,0,0,57,55,1,0,0,0,57,58,1,0,0,0,58,59,1,0,0,0,59,
		60,6,7,0,0,60,16,1,0,0,0,61,65,5,59,0,0,62,64,9,0,0,0,63,62,1,0,0,0,64,
		67,1,0,0,0,65,66,1,0,0,0,65,63,1,0,0,0,66,69,1,0,0,0,67,65,1,0,0,0,68,
		70,3,13,6,0,69,68,1,0,0,0,70,71,1,0,0,0,71,69,1,0,0,0,71,72,1,0,0,0,72,
		73,1,0,0,0,73,74,6,8,0,0,74,18,1,0,0,0,75,76,7,4,0,0,76,77,7,5,0,0,77,
		154,7,6,0,0,78,79,7,7,0,0,79,80,7,8,0,0,80,154,7,9,0,0,81,82,7,10,0,0,
		82,83,7,11,0,0,83,154,7,9,0,0,84,85,7,12,0,0,85,86,7,13,0,0,86,154,7,13,
		0,0,87,88,7,14,0,0,88,89,7,15,0,0,89,154,7,0,0,0,90,91,7,16,0,0,91,92,
		7,15,0,0,92,154,7,11,0,0,93,94,7,13,0,0,94,95,7,17,0,0,95,154,7,18,0,0,
		96,97,7,14,0,0,97,98,7,10,0,0,98,154,7,11,0,0,99,100,7,14,0,0,100,101,
		7,10,0,0,101,154,7,7,0,0,102,103,7,19,0,0,103,104,7,16,0,0,104,154,7,6,
		0,0,105,106,7,0,0,0,106,107,7,8,0,0,107,154,7,20,0,0,108,109,7,4,0,0,109,
		110,7,5,0,0,110,154,7,9,0,0,111,112,7,12,0,0,112,113,7,4,0,0,113,154,7,
		13,0,0,114,115,7,5,0,0,115,154,7,7,0,0,116,117,7,21,0,0,117,118,7,8,0,
		0,118,154,7,20,0,0,119,120,7,21,0,0,120,121,7,22,0,0,121,154,7,9,0,0,122,
		123,7,21,0,0,123,124,7,11,0,0,124,154,7,9,0,0,125,126,7,1,0,0,126,127,
		7,5,0,0,127,154,7,7,0,0,128,129,7,14,0,0,129,130,7,9,0,0,130,154,7,7,0,
		0,131,132,7,7,0,0,132,133,7,8,0,0,133,154,7,16,0,0,134,135,7,21,0,0,135,
		136,7,4,0,0,136,154,7,18,0,0,137,138,7,14,0,0,138,139,7,23,0,0,139,154,
		7,6,0,0,140,141,7,21,0,0,141,142,7,12,0,0,142,143,7,11,0,0,143,154,7,11,
		0,0,144,145,7,7,0,0,145,146,7,9,0,0,146,154,7,21,0,0,147,148,7,13,0,0,
		148,149,7,24,0,0,149,154,7,21,0,0,150,151,7,17,0,0,151,152,7,4,0,0,152,
		154,7,9,0,0,153,75,1,0,0,0,153,78,1,0,0,0,153,81,1,0,0,0,153,84,1,0,0,
		0,153,87,1,0,0,0,153,90,1,0,0,0,153,93,1,0,0,0,153,96,1,0,0,0,153,99,1,
		0,0,0,153,102,1,0,0,0,153,105,1,0,0,0,153,108,1,0,0,0,153,111,1,0,0,0,
		153,114,1,0,0,0,153,116,1,0,0,0,153,119,1,0,0,0,153,122,1,0,0,0,153,125,
		1,0,0,0,153,128,1,0,0,0,153,131,1,0,0,0,153,134,1,0,0,0,153,137,1,0,0,
		0,153,140,1,0,0,0,153,144,1,0,0,0,153,147,1,0,0,0,153,150,1,0,0,0,154,
		20,1,0,0,0,155,157,7,25,0,0,156,155,1,0,0,0,157,161,1,0,0,0,158,160,7,
		26,0,0,159,158,1,0,0,0,160,163,1,0,0,0,161,159,1,0,0,0,161,162,1,0,0,0,
		162,22,1,0,0,0,163,161,1,0,0,0,164,165,7,27,0,0,165,24,1,0,0,0,166,167,
		7,28,0,0,167,26,1,0,0,0,168,170,7,29,0,0,169,168,1,0,0,0,170,28,1,0,0,
		0,171,172,7,17,0,0,172,173,7,4,0,0,173,174,7,21,0,0,174,175,7,11,0,0,175,
		176,7,15,0,0,176,177,7,13,0,0,177,178,7,8,0,0,178,30,1,0,0,0,179,184,5,
		34,0,0,180,183,8,30,0,0,181,183,3,33,16,0,182,180,1,0,0,0,182,181,1,0,
		0,0,183,186,1,0,0,0,184,182,1,0,0,0,184,185,1,0,0,0,185,187,1,0,0,0,186,
		184,1,0,0,0,187,188,5,34,0,0,188,32,1,0,0,0,189,190,5,92,0,0,190,200,5,
		92,0,0,191,192,5,92,0,0,192,200,7,7,0,0,193,194,5,92,0,0,194,200,7,4,0,
		0,195,196,5,92,0,0,196,200,5,34,0,0,197,198,5,92,0,0,198,200,7,0,0,0,199,
		189,1,0,0,0,199,191,1,0,0,0,199,193,1,0,0,0,199,195,1,0,0,0,199,197,1,
		0,0,0,200,34,1,0,0,0,13,0,52,57,65,71,153,156,159,161,169,182,184,199,
		1,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace VM.Assembler.Parser
