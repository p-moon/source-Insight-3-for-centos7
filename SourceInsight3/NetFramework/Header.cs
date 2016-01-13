public class Header
{

	// Constructors
	public Header(string _Name, object _Value) {}
	public Header(string _Name, object _Value, bool _MustUnderstand) {}
	public Header(string _Name, object _Value, bool _MustUnderstand, string _HeaderNamespace) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string Name;
	public object Value;
	public bool MustUnderstand;
	public string HeaderNamespace;
}

