//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Dana\source\repos\LabWork1github\LabWork1github\PlayerGrammar.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace LabWork1github {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class PlayerGrammarLexer : Lexer {
	public const int
		SEMI=1, COMMA=2, FORWARD=3, LEFT=4, RIGHT=5, BACKWARD=6, MOVE=7, SHOOT=8, 
		HEALTH=9, HELP=10, WS=11;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"SEMI", "COMMA", "FORWARD", "LEFT", "RIGHT", "BACKWARD", "MOVE", "SHOOT", 
		"HEALTH", "HELP", "WS"
	};


	public PlayerGrammarLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "';'", "','", "'F'", "'L'", "'R'", "'B'", "'move'", "'shoot'", "'health'", 
		"'help'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "SEMI", "COMMA", "FORWARD", "LEFT", "RIGHT", "BACKWARD", "MOVE", 
		"SHOOT", "HEALTH", "HELP", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "PlayerGrammar.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\r@\b\x1\x4\x2\t"+
		"\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4\t"+
		"\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x3\x2\x3\x2\x3\x3\x3\x3\x3\x4\x3\x4\x3"+
		"\x5\x3\x5\x3\x6\x3\x6\x3\a\x3\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\t\x3\t\x3"+
		"\t\x3\t\x3\t\x3\t\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\v\x3\v\x3\v\x3"+
		"\v\x3\v\x3\f\x3\f\x3\f\x3\f\x2\x2\x2\r\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2"+
		"\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x3\x2\x3"+
		"\x5\x2\v\f\xF\xF\"\"?\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2"+
		"\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2"+
		"\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3"+
		"\x2\x2\x2\x3\x19\x3\x2\x2\x2\x5\x1B\x3\x2\x2\x2\a\x1D\x3\x2\x2\x2\t\x1F"+
		"\x3\x2\x2\x2\v!\x3\x2\x2\x2\r#\x3\x2\x2\x2\xF%\x3\x2\x2\x2\x11*\x3\x2"+
		"\x2\x2\x13\x30\x3\x2\x2\x2\x15\x37\x3\x2\x2\x2\x17<\x3\x2\x2\x2\x19\x1A"+
		"\a=\x2\x2\x1A\x4\x3\x2\x2\x2\x1B\x1C\a.\x2\x2\x1C\x6\x3\x2\x2\x2\x1D\x1E"+
		"\aH\x2\x2\x1E\b\x3\x2\x2\x2\x1F \aN\x2\x2 \n\x3\x2\x2\x2!\"\aT\x2\x2\""+
		"\f\x3\x2\x2\x2#$\a\x44\x2\x2$\xE\x3\x2\x2\x2%&\ao\x2\x2&\'\aq\x2\x2\'"+
		"(\ax\x2\x2()\ag\x2\x2)\x10\x3\x2\x2\x2*+\au\x2\x2+,\aj\x2\x2,-\aq\x2\x2"+
		"-.\aq\x2\x2./\av\x2\x2/\x12\x3\x2\x2\x2\x30\x31\aj\x2\x2\x31\x32\ag\x2"+
		"\x2\x32\x33\a\x63\x2\x2\x33\x34\an\x2\x2\x34\x35\av\x2\x2\x35\x36\aj\x2"+
		"\x2\x36\x14\x3\x2\x2\x2\x37\x38\aj\x2\x2\x38\x39\ag\x2\x2\x39:\an\x2\x2"+
		":;\ar\x2\x2;\x16\x3\x2\x2\x2<=\t\x2\x2\x2=>\x3\x2\x2\x2>?\b\f\x2\x2?\x18"+
		"\x3\x2\x2\x2\x3\x2\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace LabWork1github
