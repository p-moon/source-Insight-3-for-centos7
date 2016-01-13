public class Regex : System.Runtime.Serialization.ISerializable
{

	// Constructors
	public Regex(string pattern) {}
	public Regex(string pattern, RegexOptions options) {}

	// Methods
	public static string Escape(string str) {}
	public static string Unescape(string str) {}
	public virtual string ToString() {}
	public string[] GetGroupNames() {}
	public int[] GetGroupNumbers() {}
	public string GroupNameFromNumber(int i) {}
	public int GroupNumberFromName(string name) {}
	public static bool IsMatch(string input, string pattern) {}
	public static bool IsMatch(string input, string pattern, RegexOptions options) {}
	public bool IsMatch(string input) {}
	public bool IsMatch(string input, int startat) {}
	public static Match Match(string input, string pattern) {}
	public static Match Match(string input, string pattern, RegexOptions options) {}
	public Match Match(string input) {}
	public Match Match(string input, int startat) {}
	public Match Match(string input, int beginning, int length) {}
	public static MatchCollection Matches(string input, string pattern) {}
	public static MatchCollection Matches(string input, string pattern, RegexOptions options) {}
	public MatchCollection Matches(string input) {}
	public MatchCollection Matches(string input, int startat) {}
	public static string Replace(string input, string pattern, string replacement) {}
	public static string Replace(string input, string pattern, string replacement, RegexOptions options) {}
	public string Replace(string input, string replacement) {}
	public string Replace(string input, string replacement, int count) {}
	public string Replace(string input, string replacement, int count, int startat) {}
	public static string Replace(string input, string pattern, MatchEvaluator evaluator) {}
	public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options) {}
	public string Replace(string input, MatchEvaluator evaluator) {}
	public string Replace(string input, MatchEvaluator evaluator, int count) {}
	public string Replace(string input, MatchEvaluator evaluator, int count, int startat) {}
	public static string[] Split(string input, string pattern) {}
	public static string[] Split(string input, string pattern, RegexOptions options) {}
	public string[] Split(string input) {}
	public string[] Split(string input, int count) {}
	public string[] Split(string input, int count, int startat) {}
	public static void CompileToAssembly(RegexCompilationInfo[] regexinfos, System.Reflection.AssemblyName assemblyname) {}
	public static void CompileToAssembly(RegexCompilationInfo[] regexinfos, System.Reflection.AssemblyName assemblyname, System.Reflection.Emit.CustomAttributeBuilder[] attributes) {}
	public static void CompileToAssembly(RegexCompilationInfo[] regexinfos, System.Reflection.AssemblyName assemblyname, System.Reflection.Emit.CustomAttributeBuilder[] attributes, string resourceFile) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int CacheSize { get{} set{} }
	public RegexOptions Options { get{} }
	public bool RightToLeft { get{} }
}

