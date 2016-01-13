public class AspCodeRegex : System.Text.RegularExpressions.Regex, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public AspCodeRegex() {}

	// Methods
	public virtual string ToString() {}
	public string[] GetGroupNames() {}
	public int[] GetGroupNumbers() {}
	public string GroupNameFromNumber(int i) {}
	public int GroupNumberFromName(string name) {}
	public bool IsMatch(string input) {}
	public bool IsMatch(string input, int startat) {}
	public System.Text.RegularExpressions.Match Match(string input) {}
	public System.Text.RegularExpressions.Match Match(string input, int startat) {}
	public System.Text.RegularExpressions.Match Match(string input, int beginning, int length) {}
	public System.Text.RegularExpressions.MatchCollection Matches(string input) {}
	public System.Text.RegularExpressions.MatchCollection Matches(string input, int startat) {}
	public string Replace(string input, string replacement) {}
	public string Replace(string input, string replacement, int count) {}
	public string Replace(string input, string replacement, int count, int startat) {}
	public string Replace(string input, System.Text.RegularExpressions.MatchEvaluator evaluator) {}
	public string Replace(string input, System.Text.RegularExpressions.MatchEvaluator evaluator, int count) {}
	public string Replace(string input, System.Text.RegularExpressions.MatchEvaluator evaluator, int count, int startat) {}
	public string[] Split(string input) {}
	public string[] Split(string input, int count) {}
	public string[] Split(string input, int count, int startat) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Text.RegularExpressions.RegexOptions Options { get{} }
	public bool RightToLeft { get{} }
}

