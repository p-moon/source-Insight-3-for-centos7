public class IdnMapping
{

	// Constructors
	public IdnMapping() {}

	// Methods
	public string GetAscii(string unicode) {}
	public string GetAscii(string unicode, int index) {}
	public string GetAscii(string unicode, int index, int count) {}
	public string GetUnicode(string ascii) {}
	public string GetUnicode(string ascii, int index) {}
	public string GetUnicode(string ascii, int index, int count) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool AllowUnassigned { get{} set{} }
	public bool UseStd3AsciiRules { get{} set{} }
}

