//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\dzera\Documents\C#\Raudonakmenis1\raudonakmenis\Raudonakmenis\Grammar.g4 by ANTLR 4.6.6

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
public partial class GrammarLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, T__27=28, T__28=29, T__29=30, T__30=31, 
		T__31=32, T__32=33, T__33=34, T__34=35, T__35=36, T__36=37, T__37=38, 
		T__38=39, T__39=40, T__40=41, T__41=42, WHILE=43, BOOL_OPERATOR=44, INTEGER=45, 
		FLOAT=46, STRING=47, BOOL=48, NULL=49, WS=50, IDENTIFIER=51;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "T__24", 
		"T__25", "T__26", "T__27", "T__28", "T__29", "T__30", "T__31", "T__32", 
		"T__33", "T__34", "T__35", "T__36", "T__37", "T__38", "T__39", "T__40", 
		"T__41", "WHILE", "BOOL_OPERATOR", "INTEGER", "FLOAT", "STRING", "BOOL", 
		"NULL", "WS", "IDENTIFIER"
	};


	public GrammarLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "';'", "'('", "','", "')'", "'if'", "'else'", "'!'", "'='", "'%%'", 
		"'$$'", "'@@'", "'--'", "'+='", "'-='", "'+++'", "'---'", "'/='", "'*='", 
		"'%='", "'^='", "'*'", "'/'", "'%'", "'+'", "'-'", "'=='", "'!='", "'>'", 
		"'<'", "'>='", "'<='", "'{'", "'}'", "'class'", "'new'", "'.'", "'int'", 
		"'float'", "'string'", "'bool'", "'void'", "'return'", null, null, null, 
		null, null, null, "'null'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, "WHILE", "BOOL_OPERATOR", "INTEGER", 
		"FLOAT", "STRING", "BOOL", "NULL", "WS", "IDENTIFIER"
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
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\x35\x142\b\x1\x4"+
		"\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b"+
		"\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4"+
		"\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15"+
		"\t\x15\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A"+
		"\x4\x1B\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 "+
		"\t \x4!\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t"+
		")\x4*\t*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x4/\t/\x4\x30\t\x30\x4\x31\t\x31"+
		"\x4\x32\t\x32\x4\x33\t\x33\x4\x34\t\x34\x3\x2\x3\x2\x3\x3\x3\x3\x3\x4"+
		"\x3\x4\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\a\x3\a\x3\b\x3"+
		"\b\x3\t\x3\t\x3\n\x3\n\x3\n\x3\v\x3\v\x3\v\x3\f\x3\f\x3\f\x3\r\x3\r\x3"+
		"\r\x3\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10\x3\x10\x3"+
		"\x11\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3\x12\x3\x13\x3\x13\x3\x13\x3"+
		"\x14\x3\x14\x3\x14\x3\x15\x3\x15\x3\x15\x3\x16\x3\x16\x3\x17\x3\x17\x3"+
		"\x18\x3\x18\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1B\x3\x1C\x3"+
		"\x1C\x3\x1C\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1F\x3\x1F\x3\x1F\x3 \x3 \x3"+
		" \x3!\x3!\x3\"\x3\"\x3#\x3#\x3#\x3#\x3#\x3#\x3$\x3$\x3$\x3$\x3%\x3%\x3"+
		"&\x3&\x3&\x3&\x3\'\x3\'\x3\'\x3\'\x3\'\x3\'\x3(\x3(\x3(\x3(\x3(\x3(\x3"+
		"(\x3)\x3)\x3)\x3)\x3)\x3*\x3*\x3*\x3*\x3*\x3+\x3+\x3+\x3+\x3+\x3+\x3+"+
		"\x3,\x3,\x3,\x3,\x3,\x3,\x3,\x3,\x3,\x3,\x5,\xFA\n,\x3-\x3-\x3-\x3-\x3"+
		"-\x3-\x3-\x3-\x5-\x104\n-\x3.\x5.\x107\n.\x3.\x6.\x10A\n.\r.\xE.\x10B"+
		"\x3/\x5/\x10F\n/\x3/\x6/\x112\n/\r/\xE/\x113\x3/\x3/\x6/\x118\n/\r/\xE"+
		"/\x119\x3\x30\x3\x30\a\x30\x11E\n\x30\f\x30\xE\x30\x121\v\x30\x3\x30\x3"+
		"\x30\x3\x31\x3\x31\x3\x31\x3\x31\x3\x31\x3\x31\x3\x31\x3\x31\x3\x31\x5"+
		"\x31\x12E\n\x31\x3\x32\x3\x32\x3\x32\x3\x32\x3\x32\x3\x33\x6\x33\x136"+
		"\n\x33\r\x33\xE\x33\x137\x3\x33\x3\x33\x3\x34\x3\x34\a\x34\x13E\n\x34"+
		"\f\x34\xE\x34\x141\v\x34\x2\x2\x2\x35\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6"+
		"\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B"+
		"\x2\xF\x1D\x2\x10\x1F\x2\x11!\x2\x12#\x2\x13%\x2\x14\'\x2\x15)\x2\x16"+
		"+\x2\x17-\x2\x18/\x2\x19\x31\x2\x1A\x33\x2\x1B\x35\x2\x1C\x37\x2\x1D\x39"+
		"\x2\x1E;\x2\x1F=\x2 ?\x2!\x41\x2\"\x43\x2#\x45\x2$G\x2%I\x2&K\x2\'M\x2"+
		"(O\x2)Q\x2*S\x2+U\x2,W\x2-Y\x2.[\x2/]\x2\x30_\x2\x31\x61\x2\x32\x63\x2"+
		"\x33\x65\x2\x34g\x2\x35\x3\x2\a\x3\x2\x32;\x3\x2$$\x5\x2\v\f\xF\xF\"\""+
		"\x5\x2\x43\\\x61\x61\x63|\x6\x2\x32;\x43\\\x61\x61\x63|\x14D\x2\x3\x3"+
		"\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3"+
		"\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13"+
		"\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2"+
		"\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2"+
		"\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2"+
		"+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33"+
		"\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2"+
		"\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2\x2\x2\x41\x3\x2\x2\x2\x2"+
		"\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2\x2G\x3\x2\x2\x2\x2I\x3\x2\x2\x2\x2"+
		"K\x3\x2\x2\x2\x2M\x3\x2\x2\x2\x2O\x3\x2\x2\x2\x2Q\x3\x2\x2\x2\x2S\x3\x2"+
		"\x2\x2\x2U\x3\x2\x2\x2\x2W\x3\x2\x2\x2\x2Y\x3\x2\x2\x2\x2[\x3\x2\x2\x2"+
		"\x2]\x3\x2\x2\x2\x2_\x3\x2\x2\x2\x2\x61\x3\x2\x2\x2\x2\x63\x3\x2\x2\x2"+
		"\x2\x65\x3\x2\x2\x2\x2g\x3\x2\x2\x2\x3i\x3\x2\x2\x2\x5k\x3\x2\x2\x2\a"+
		"m\x3\x2\x2\x2\to\x3\x2\x2\x2\vq\x3\x2\x2\x2\rt\x3\x2\x2\x2\xFy\x3\x2\x2"+
		"\x2\x11{\x3\x2\x2\x2\x13}\x3\x2\x2\x2\x15\x80\x3\x2\x2\x2\x17\x83\x3\x2"+
		"\x2\x2\x19\x86\x3\x2\x2\x2\x1B\x89\x3\x2\x2\x2\x1D\x8C\x3\x2\x2\x2\x1F"+
		"\x8F\x3\x2\x2\x2!\x93\x3\x2\x2\x2#\x97\x3\x2\x2\x2%\x9A\x3\x2\x2\x2\'"+
		"\x9D\x3\x2\x2\x2)\xA0\x3\x2\x2\x2+\xA3\x3\x2\x2\x2-\xA5\x3\x2\x2\x2/\xA7"+
		"\x3\x2\x2\x2\x31\xA9\x3\x2\x2\x2\x33\xAB\x3\x2\x2\x2\x35\xAD\x3\x2\x2"+
		"\x2\x37\xB0\x3\x2\x2\x2\x39\xB3\x3\x2\x2\x2;\xB5\x3\x2\x2\x2=\xB7\x3\x2"+
		"\x2\x2?\xBA\x3\x2\x2\x2\x41\xBD\x3\x2\x2\x2\x43\xBF\x3\x2\x2\x2\x45\xC1"+
		"\x3\x2\x2\x2G\xC7\x3\x2\x2\x2I\xCB\x3\x2\x2\x2K\xCD\x3\x2\x2\x2M\xD1\x3"+
		"\x2\x2\x2O\xD7\x3\x2\x2\x2Q\xDE\x3\x2\x2\x2S\xE3\x3\x2\x2\x2U\xE8\x3\x2"+
		"\x2\x2W\xF9\x3\x2\x2\x2Y\x103\x3\x2\x2\x2[\x106\x3\x2\x2\x2]\x10E\x3\x2"+
		"\x2\x2_\x11B\x3\x2\x2\x2\x61\x12D\x3\x2\x2\x2\x63\x12F\x3\x2\x2\x2\x65"+
		"\x135\x3\x2\x2\x2g\x13B\x3\x2\x2\x2ij\a=\x2\x2j\x4\x3\x2\x2\x2kl\a*\x2"+
		"\x2l\x6\x3\x2\x2\x2mn\a.\x2\x2n\b\x3\x2\x2\x2op\a+\x2\x2p\n\x3\x2\x2\x2"+
		"qr\ak\x2\x2rs\ah\x2\x2s\f\x3\x2\x2\x2tu\ag\x2\x2uv\an\x2\x2vw\au\x2\x2"+
		"wx\ag\x2\x2x\xE\x3\x2\x2\x2yz\a#\x2\x2z\x10\x3\x2\x2\x2{|\a?\x2\x2|\x12"+
		"\x3\x2\x2\x2}~\a\'\x2\x2~\x7F\a\'\x2\x2\x7F\x14\x3\x2\x2\x2\x80\x81\a"+
		"&\x2\x2\x81\x82\a&\x2\x2\x82\x16\x3\x2\x2\x2\x83\x84\a\x42\x2\x2\x84\x85"+
		"\a\x42\x2\x2\x85\x18\x3\x2\x2\x2\x86\x87\a/\x2\x2\x87\x88\a/\x2\x2\x88"+
		"\x1A\x3\x2\x2\x2\x89\x8A\a-\x2\x2\x8A\x8B\a?\x2\x2\x8B\x1C\x3\x2\x2\x2"+
		"\x8C\x8D\a/\x2\x2\x8D\x8E\a?\x2\x2\x8E\x1E\x3\x2\x2\x2\x8F\x90\a-\x2\x2"+
		"\x90\x91\a-\x2\x2\x91\x92\a-\x2\x2\x92 \x3\x2\x2\x2\x93\x94\a/\x2\x2\x94"+
		"\x95\a/\x2\x2\x95\x96\a/\x2\x2\x96\"\x3\x2\x2\x2\x97\x98\a\x31\x2\x2\x98"+
		"\x99\a?\x2\x2\x99$\x3\x2\x2\x2\x9A\x9B\a,\x2\x2\x9B\x9C\a?\x2\x2\x9C&"+
		"\x3\x2\x2\x2\x9D\x9E\a\'\x2\x2\x9E\x9F\a?\x2\x2\x9F(\x3\x2\x2\x2\xA0\xA1"+
		"\a`\x2\x2\xA1\xA2\a?\x2\x2\xA2*\x3\x2\x2\x2\xA3\xA4\a,\x2\x2\xA4,\x3\x2"+
		"\x2\x2\xA5\xA6\a\x31\x2\x2\xA6.\x3\x2\x2\x2\xA7\xA8\a\'\x2\x2\xA8\x30"+
		"\x3\x2\x2\x2\xA9\xAA\a-\x2\x2\xAA\x32\x3\x2\x2\x2\xAB\xAC\a/\x2\x2\xAC"+
		"\x34\x3\x2\x2\x2\xAD\xAE\a?\x2\x2\xAE\xAF\a?\x2\x2\xAF\x36\x3\x2\x2\x2"+
		"\xB0\xB1\a#\x2\x2\xB1\xB2\a?\x2\x2\xB2\x38\x3\x2\x2\x2\xB3\xB4\a@\x2\x2"+
		"\xB4:\x3\x2\x2\x2\xB5\xB6\a>\x2\x2\xB6<\x3\x2\x2\x2\xB7\xB8\a@\x2\x2\xB8"+
		"\xB9\a?\x2\x2\xB9>\x3\x2\x2\x2\xBA\xBB\a>\x2\x2\xBB\xBC\a?\x2\x2\xBC@"+
		"\x3\x2\x2\x2\xBD\xBE\a}\x2\x2\xBE\x42\x3\x2\x2\x2\xBF\xC0\a\x7F\x2\x2"+
		"\xC0\x44\x3\x2\x2\x2\xC1\xC2\a\x65\x2\x2\xC2\xC3\an\x2\x2\xC3\xC4\a\x63"+
		"\x2\x2\xC4\xC5\au\x2\x2\xC5\xC6\au\x2\x2\xC6\x46\x3\x2\x2\x2\xC7\xC8\a"+
		"p\x2\x2\xC8\xC9\ag\x2\x2\xC9\xCA\ay\x2\x2\xCAH\x3\x2\x2\x2\xCB\xCC\a\x30"+
		"\x2\x2\xCCJ\x3\x2\x2\x2\xCD\xCE\ak\x2\x2\xCE\xCF\ap\x2\x2\xCF\xD0\av\x2"+
		"\x2\xD0L\x3\x2\x2\x2\xD1\xD2\ah\x2\x2\xD2\xD3\an\x2\x2\xD3\xD4\aq\x2\x2"+
		"\xD4\xD5\a\x63\x2\x2\xD5\xD6\av\x2\x2\xD6N\x3\x2\x2\x2\xD7\xD8\au\x2\x2"+
		"\xD8\xD9\av\x2\x2\xD9\xDA\at\x2\x2\xDA\xDB\ak\x2\x2\xDB\xDC\ap\x2\x2\xDC"+
		"\xDD\ai\x2\x2\xDDP\x3\x2\x2\x2\xDE\xDF\a\x64\x2\x2\xDF\xE0\aq\x2\x2\xE0"+
		"\xE1\aq\x2\x2\xE1\xE2\an\x2\x2\xE2R\x3\x2\x2\x2\xE3\xE4\ax\x2\x2\xE4\xE5"+
		"\aq\x2\x2\xE5\xE6\ak\x2\x2\xE6\xE7\a\x66\x2\x2\xE7T\x3\x2\x2\x2\xE8\xE9"+
		"\at\x2\x2\xE9\xEA\ag\x2\x2\xEA\xEB\av\x2\x2\xEB\xEC\aw\x2\x2\xEC\xED\a"+
		"t\x2\x2\xED\xEE\ap\x2\x2\xEEV\x3\x2\x2\x2\xEF\xF0\ay\x2\x2\xF0\xF1\aj"+
		"\x2\x2\xF1\xF2\ak\x2\x2\xF2\xF3\an\x2\x2\xF3\xFA\ag\x2\x2\xF4\xF5\aw\x2"+
		"\x2\xF5\xF6\ap\x2\x2\xF6\xF7\av\x2\x2\xF7\xF8\ak\x2\x2\xF8\xFA\an\x2\x2"+
		"\xF9\xEF\x3\x2\x2\x2\xF9\xF4\x3\x2\x2\x2\xFAX\x3\x2\x2\x2\xFB\xFC\a\x63"+
		"\x2\x2\xFC\xFD\ap\x2\x2\xFD\x104\a\x66\x2\x2\xFE\xFF\aq\x2\x2\xFF\x104"+
		"\at\x2\x2\x100\x101\az\x2\x2\x101\x102\aq\x2\x2\x102\x104\at\x2\x2\x103"+
		"\xFB\x3\x2\x2\x2\x103\xFE\x3\x2\x2\x2\x103\x100\x3\x2\x2\x2\x104Z\x3\x2"+
		"\x2\x2\x105\x107\a/\x2\x2\x106\x105\x3\x2\x2\x2\x106\x107\x3\x2\x2\x2"+
		"\x107\x109\x3\x2\x2\x2\x108\x10A\t\x2\x2\x2\x109\x108\x3\x2\x2\x2\x10A"+
		"\x10B\x3\x2\x2\x2\x10B\x109\x3\x2\x2\x2\x10B\x10C\x3\x2\x2\x2\x10C\\\x3"+
		"\x2\x2\x2\x10D\x10F\a/\x2\x2\x10E\x10D\x3\x2\x2\x2\x10E\x10F\x3\x2\x2"+
		"\x2\x10F\x111\x3\x2\x2\x2\x110\x112\t\x2\x2\x2\x111\x110\x3\x2\x2\x2\x112"+
		"\x113\x3\x2\x2\x2\x113\x111\x3\x2\x2\x2\x113\x114\x3\x2\x2\x2\x114\x115"+
		"\x3\x2\x2\x2\x115\x117\a\x30\x2\x2\x116\x118\t\x2\x2\x2\x117\x116\x3\x2"+
		"\x2\x2\x118\x119\x3\x2\x2\x2\x119\x117\x3\x2\x2\x2\x119\x11A\x3\x2\x2"+
		"\x2\x11A^\x3\x2\x2\x2\x11B\x11F\a$\x2\x2\x11C\x11E\n\x3\x2\x2\x11D\x11C"+
		"\x3\x2\x2\x2\x11E\x121\x3\x2\x2\x2\x11F\x11D\x3\x2\x2\x2\x11F\x120\x3"+
		"\x2\x2\x2\x120\x122\x3\x2\x2\x2\x121\x11F\x3\x2\x2\x2\x122\x123\a$\x2"+
		"\x2\x123`\x3\x2\x2\x2\x124\x125\av\x2\x2\x125\x126\at\x2\x2\x126\x127"+
		"\aw\x2\x2\x127\x12E\ag\x2\x2\x128\x129\ah\x2\x2\x129\x12A\a\x63\x2\x2"+
		"\x12A\x12B\an\x2\x2\x12B\x12C\au\x2\x2\x12C\x12E\ag\x2\x2\x12D\x124\x3"+
		"\x2\x2\x2\x12D\x128\x3\x2\x2\x2\x12E\x62\x3\x2\x2\x2\x12F\x130\ap\x2\x2"+
		"\x130\x131\aw\x2\x2\x131\x132\an\x2\x2\x132\x133\an\x2\x2\x133\x64\x3"+
		"\x2\x2\x2\x134\x136\t\x4\x2\x2\x135\x134\x3\x2\x2\x2\x136\x137\x3\x2\x2"+
		"\x2\x137\x135\x3\x2\x2\x2\x137\x138\x3\x2\x2\x2\x138\x139\x3\x2\x2\x2"+
		"\x139\x13A\b\x33\x2\x2\x13A\x66\x3\x2\x2\x2\x13B\x13F\t\x5\x2\x2\x13C"+
		"\x13E\t\x6\x2\x2\x13D\x13C\x3\x2\x2\x2\x13E\x141\x3\x2\x2\x2\x13F\x13D"+
		"\x3\x2\x2\x2\x13F\x140\x3\x2\x2\x2\x140h\x3\x2\x2\x2\x141\x13F\x3\x2\x2"+
		"\x2\xE\x2\xF9\x103\x106\x10B\x10E\x113\x119\x11F\x12D\x137\x13F\x3\b\x2"+
		"\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Raudonakmenis
