public class StringInfo
{

	// Constructors
	public StringInfo() {}
	public StringInfo(string value) {}

	// Methods
	public virtual bool Equals(object value) {}
	public virtual int GetHashCode() {}
	public string SubstringByTextElements(int startingTextElement) {}
	public string SubstringByTextElements(int startingTextElement, int lengthInTextElements) {}
	public static string GetNextTextElement(string str) {}
	public static string GetNextTextElement(string str, int index) {}
	public static TextElementEnumerator GetTextElementEnumerator(string str) {}
	public static TextElementEnumerator GetTextElementEnumerator(string str, int index) {}
	public static int[] ParseCombiningCharacters(string str) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string String { get{} set{} }
	public int LengthInTextElements { get{} }
}

