//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\dzera\Documents\C#\Raudonakmenis\Raudonakmenis\Grammar.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Raudonakmenis {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class CombinedLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, T__27=28, T__28=29, T__29=30, T__30=31, 
		T__31=32, T__32=33, WHILE=34, BOOL_OPERATOR=35, INTEGER=36, FLOAT=37, 
		STRING=38, BOOL=39, NULL=40, WS=41, IDENTIFIER=42;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "T__24", 
		"T__25", "T__26", "T__27", "T__28", "T__29", "T__30", "T__31", "T__32", 
		"WHILE", "BOOL_OPERATOR", "INTEGER", "FLOAT", "STRING", "BOOL", "NULL", 
		"WS", "IDENTIFIER"
	};


	public CombinedLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "';'", "'='", "'('", "','", "')'", "'if'", "'else'", "'print'", 
		"'!'", "'*'", "'/'", "'%'", "'+'", "'-'", "'++'", "'--'", "'+='", "'-='", 
		"'=='", "'!='", "'>'", "'<'", "'>='", "'<='", "'{'", "'}'", "'class'", 
		"'int'", "'float'", "'string'", "'bool'", "'void'", "'return'", null, 
		null, null, null, null, null, "'null'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, "WHILE", "BOOL_OPERATOR", 
		"INTEGER", "FLOAT", "STRING", "BOOL", "NULL", "WS", "IDENTIFIER"
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

	public override string GrammarFileName { get { return "Grammar.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2,\x110\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!"+
		"\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t)\x4*\t"+
		"*\x4+\t+\x3\x2\x3\x2\x3\x3\x3\x3\x3\x4\x3\x4\x3\x5\x3\x5\x3\x6\x3\x6\x3"+
		"\a\x3\a\x3\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3"+
		"\n\x3\n\x3\v\x3\v\x3\f\x3\f\x3\r\x3\r\x3\xE\x3\xE\x3\xF\x3\xF\x3\x10\x3"+
		"\x10\x3\x10\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3\x12\x3\x13\x3\x13\x3"+
		"\x13\x3\x14\x3\x14\x3\x14\x3\x15\x3\x15\x3\x15\x3\x16\x3\x16\x3\x17\x3"+
		"\x17\x3\x18\x3\x18\x3\x18\x3\x19\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1B\x3"+
		"\x1B\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1D\x3\x1D\x3\x1D\x3"+
		"\x1D\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1F\x3\x1F\x3\x1F\x3"+
		"\x1F\x3\x1F\x3\x1F\x3\x1F\x3 \x3 \x3 \x3 \x3 \x3!\x3!\x3!\x3!\x3!\x3\""+
		"\x3\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3#\x3#\x3#\x3#\x3#\x3#\x3#\x3#\x3#\x3"+
		"#\x5#\xCE\n#\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x5$\xD8\n$\x3%\x6%\xDB\n"+
		"%\r%\xE%\xDC\x3&\x6&\xE0\n&\r&\xE&\xE1\x3&\x3&\x6&\xE6\n&\r&\xE&\xE7\x3"+
		"\'\x3\'\a\'\xEC\n\'\f\'\xE\'\xEF\v\'\x3\'\x3\'\x3(\x3(\x3(\x3(\x3(\x3"+
		"(\x3(\x3(\x3(\x5(\xFC\n(\x3)\x3)\x3)\x3)\x3)\x3*\x6*\x104\n*\r*\xE*\x105"+
		"\x3*\x3*\x3+\x3+\a+\x10C\n+\f+\xE+\x10F\v+\x2\x2\x2,\x3\x2\x3\x5\x2\x4"+
		"\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17"+
		"\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2\x11!\x2\x12#\x2\x13%\x2\x14"+
		"\'\x2\x15)\x2\x16+\x2\x17-\x2\x18/\x2\x19\x31\x2\x1A\x33\x2\x1B\x35\x2"+
		"\x1C\x37\x2\x1D\x39\x2\x1E;\x2\x1F=\x2 ?\x2!\x41\x2\"\x43\x2#\x45\x2$"+
		"G\x2%I\x2&K\x2\'M\x2(O\x2)Q\x2*S\x2+U\x2,\x3\x2\a\x3\x2\x32;\x3\x2$$\x5"+
		"\x2\v\f\xF\xF\"\"\x5\x2\x43\\\x61\x61\x63|\x6\x2\x32;\x43\\\x61\x61\x63"+
		"|\x119\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2"+
		"\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2"+
		"\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19"+
		"\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2"+
		"\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)"+
		"\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3"+
		"\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2\x2"+
		"\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2\x2\x2\x41"+
		"\x3\x2\x2\x2\x2\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2\x2G\x3\x2\x2\x2\x2"+
		"I\x3\x2\x2\x2\x2K\x3\x2\x2\x2\x2M\x3\x2\x2\x2\x2O\x3\x2\x2\x2\x2Q\x3\x2"+
		"\x2\x2\x2S\x3\x2\x2\x2\x2U\x3\x2\x2\x2\x3W\x3\x2\x2\x2\x5Y\x3\x2\x2\x2"+
		"\a[\x3\x2\x2\x2\t]\x3\x2\x2\x2\v_\x3\x2\x2\x2\r\x61\x3\x2\x2\x2\xF\x64"+
		"\x3\x2\x2\x2\x11i\x3\x2\x2\x2\x13o\x3\x2\x2\x2\x15q\x3\x2\x2\x2\x17s\x3"+
		"\x2\x2\x2\x19u\x3\x2\x2\x2\x1Bw\x3\x2\x2\x2\x1Dy\x3\x2\x2\x2\x1F{\x3\x2"+
		"\x2\x2!~\x3\x2\x2\x2#\x81\x3\x2\x2\x2%\x84\x3\x2\x2\x2\'\x87\x3\x2\x2"+
		"\x2)\x8A\x3\x2\x2\x2+\x8D\x3\x2\x2\x2-\x8F\x3\x2\x2\x2/\x91\x3\x2\x2\x2"+
		"\x31\x94\x3\x2\x2\x2\x33\x97\x3\x2\x2\x2\x35\x99\x3\x2\x2\x2\x37\x9B\x3"+
		"\x2\x2\x2\x39\xA1\x3\x2\x2\x2;\xA5\x3\x2\x2\x2=\xAB\x3\x2\x2\x2?\xB2\x3"+
		"\x2\x2\x2\x41\xB7\x3\x2\x2\x2\x43\xBC\x3\x2\x2\x2\x45\xCD\x3\x2\x2\x2"+
		"G\xD7\x3\x2\x2\x2I\xDA\x3\x2\x2\x2K\xDF\x3\x2\x2\x2M\xE9\x3\x2\x2\x2O"+
		"\xFB\x3\x2\x2\x2Q\xFD\x3\x2\x2\x2S\x103\x3\x2\x2\x2U\x109\x3\x2\x2\x2"+
		"WX\a=\x2\x2X\x4\x3\x2\x2\x2YZ\a?\x2\x2Z\x6\x3\x2\x2\x2[\\\a*\x2\x2\\\b"+
		"\x3\x2\x2\x2]^\a.\x2\x2^\n\x3\x2\x2\x2_`\a+\x2\x2`\f\x3\x2\x2\x2\x61\x62"+
		"\ak\x2\x2\x62\x63\ah\x2\x2\x63\xE\x3\x2\x2\x2\x64\x65\ag\x2\x2\x65\x66"+
		"\an\x2\x2\x66g\au\x2\x2gh\ag\x2\x2h\x10\x3\x2\x2\x2ij\ar\x2\x2jk\at\x2"+
		"\x2kl\ak\x2\x2lm\ap\x2\x2mn\av\x2\x2n\x12\x3\x2\x2\x2op\a#\x2\x2p\x14"+
		"\x3\x2\x2\x2qr\a,\x2\x2r\x16\x3\x2\x2\x2st\a\x31\x2\x2t\x18\x3\x2\x2\x2"+
		"uv\a\'\x2\x2v\x1A\x3\x2\x2\x2wx\a-\x2\x2x\x1C\x3\x2\x2\x2yz\a/\x2\x2z"+
		"\x1E\x3\x2\x2\x2{|\a-\x2\x2|}\a-\x2\x2} \x3\x2\x2\x2~\x7F\a/\x2\x2\x7F"+
		"\x80\a/\x2\x2\x80\"\x3\x2\x2\x2\x81\x82\a-\x2\x2\x82\x83\a?\x2\x2\x83"+
		"$\x3\x2\x2\x2\x84\x85\a/\x2\x2\x85\x86\a?\x2\x2\x86&\x3\x2\x2\x2\x87\x88"+
		"\a?\x2\x2\x88\x89\a?\x2\x2\x89(\x3\x2\x2\x2\x8A\x8B\a#\x2\x2\x8B\x8C\a"+
		"?\x2\x2\x8C*\x3\x2\x2\x2\x8D\x8E\a@\x2\x2\x8E,\x3\x2\x2\x2\x8F\x90\a>"+
		"\x2\x2\x90.\x3\x2\x2\x2\x91\x92\a@\x2\x2\x92\x93\a?\x2\x2\x93\x30\x3\x2"+
		"\x2\x2\x94\x95\a>\x2\x2\x95\x96\a?\x2\x2\x96\x32\x3\x2\x2\x2\x97\x98\a"+
		"}\x2\x2\x98\x34\x3\x2\x2\x2\x99\x9A\a\x7F\x2\x2\x9A\x36\x3\x2\x2\x2\x9B"+
		"\x9C\a\x65\x2\x2\x9C\x9D\an\x2\x2\x9D\x9E\a\x63\x2\x2\x9E\x9F\au\x2\x2"+
		"\x9F\xA0\au\x2\x2\xA0\x38\x3\x2\x2\x2\xA1\xA2\ak\x2\x2\xA2\xA3\ap\x2\x2"+
		"\xA3\xA4\av\x2\x2\xA4:\x3\x2\x2\x2\xA5\xA6\ah\x2\x2\xA6\xA7\an\x2\x2\xA7"+
		"\xA8\aq\x2\x2\xA8\xA9\a\x63\x2\x2\xA9\xAA\av\x2\x2\xAA<\x3\x2\x2\x2\xAB"+
		"\xAC\au\x2\x2\xAC\xAD\av\x2\x2\xAD\xAE\at\x2\x2\xAE\xAF\ak\x2\x2\xAF\xB0"+
		"\ap\x2\x2\xB0\xB1\ai\x2\x2\xB1>\x3\x2\x2\x2\xB2\xB3\a\x64\x2\x2\xB3\xB4"+
		"\aq\x2\x2\xB4\xB5\aq\x2\x2\xB5\xB6\an\x2\x2\xB6@\x3\x2\x2\x2\xB7\xB8\a"+
		"x\x2\x2\xB8\xB9\aq\x2\x2\xB9\xBA\ak\x2\x2\xBA\xBB\a\x66\x2\x2\xBB\x42"+
		"\x3\x2\x2\x2\xBC\xBD\at\x2\x2\xBD\xBE\ag\x2\x2\xBE\xBF\av\x2\x2\xBF\xC0"+
		"\aw\x2\x2\xC0\xC1\at\x2\x2\xC1\xC2\ap\x2\x2\xC2\x44\x3\x2\x2\x2\xC3\xC4"+
		"\ay\x2\x2\xC4\xC5\aj\x2\x2\xC5\xC6\ak\x2\x2\xC6\xC7\an\x2\x2\xC7\xCE\a"+
		"g\x2\x2\xC8\xC9\aw\x2\x2\xC9\xCA\ap\x2\x2\xCA\xCB\av\x2\x2\xCB\xCC\ak"+
		"\x2\x2\xCC\xCE\an\x2\x2\xCD\xC3\x3\x2\x2\x2\xCD\xC8\x3\x2\x2\x2\xCE\x46"+
		"\x3\x2\x2\x2\xCF\xD0\a\x63\x2\x2\xD0\xD1\ap\x2\x2\xD1\xD8\a\x66\x2\x2"+
		"\xD2\xD3\aq\x2\x2\xD3\xD8\at\x2\x2\xD4\xD5\az\x2\x2\xD5\xD6\aq\x2\x2\xD6"+
		"\xD8\at\x2\x2\xD7\xCF\x3\x2\x2\x2\xD7\xD2\x3\x2\x2\x2\xD7\xD4\x3\x2\x2"+
		"\x2\xD8H\x3\x2\x2\x2\xD9\xDB\t\x2\x2\x2\xDA\xD9\x3\x2\x2\x2\xDB\xDC\x3"+
		"\x2\x2\x2\xDC\xDA\x3\x2\x2\x2\xDC\xDD\x3\x2\x2\x2\xDDJ\x3\x2\x2\x2\xDE"+
		"\xE0\t\x2\x2\x2\xDF\xDE\x3\x2\x2\x2\xE0\xE1\x3\x2\x2\x2\xE1\xDF\x3\x2"+
		"\x2\x2\xE1\xE2\x3\x2\x2\x2\xE2\xE3\x3\x2\x2\x2\xE3\xE5\a\x30\x2\x2\xE4"+
		"\xE6\t\x2\x2\x2\xE5\xE4\x3\x2\x2\x2\xE6\xE7\x3\x2\x2\x2\xE7\xE5\x3\x2"+
		"\x2\x2\xE7\xE8\x3\x2\x2\x2\xE8L\x3\x2\x2\x2\xE9\xED\a$\x2\x2\xEA\xEC\n"+
		"\x3\x2\x2\xEB\xEA\x3\x2\x2\x2\xEC\xEF\x3\x2\x2\x2\xED\xEB\x3\x2\x2\x2"+
		"\xED\xEE\x3\x2\x2\x2\xEE\xF0\x3\x2\x2\x2\xEF\xED\x3\x2\x2\x2\xF0\xF1\a"+
		"$\x2\x2\xF1N\x3\x2\x2\x2\xF2\xF3\av\x2\x2\xF3\xF4\at\x2\x2\xF4\xF5\aw"+
		"\x2\x2\xF5\xFC\ag\x2\x2\xF6\xF7\ah\x2\x2\xF7\xF8\a\x63\x2\x2\xF8\xF9\a"+
		"n\x2\x2\xF9\xFA\au\x2\x2\xFA\xFC\ag\x2\x2\xFB\xF2\x3\x2\x2\x2\xFB\xF6"+
		"\x3\x2\x2\x2\xFCP\x3\x2\x2\x2\xFD\xFE\ap\x2\x2\xFE\xFF\aw\x2\x2\xFF\x100"+
		"\an\x2\x2\x100\x101\an\x2\x2\x101R\x3\x2\x2\x2\x102\x104\t\x4\x2\x2\x103"+
		"\x102\x3\x2\x2\x2\x104\x105\x3\x2\x2\x2\x105\x103\x3\x2\x2\x2\x105\x106"+
		"\x3\x2\x2\x2\x106\x107\x3\x2\x2\x2\x107\x108\b*\x2\x2\x108T\x3\x2\x2\x2"+
		"\x109\x10D\t\x5\x2\x2\x10A\x10C\t\x6\x2\x2\x10B\x10A\x3\x2\x2\x2\x10C"+
		"\x10F\x3\x2\x2\x2\x10D\x10B\x3\x2\x2\x2\x10D\x10E\x3\x2\x2\x2\x10EV\x3"+
		"\x2\x2\x2\x10F\x10D\x3\x2\x2\x2\f\x2\xCD\xD7\xDC\xE1\xE7\xED\xFB\x105"+
		"\x10D\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Raudonakmenis
