public class HelpKeywordAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public HelpKeywordAttribute() {}
	public HelpKeywordAttribute(string keyword) {}
	public HelpKeywordAttribute(Type t) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public HelpKeywordAttribute Default;

	// Properties
	public string HelpKeyword { get{} }
	public object TypeId { get{} }
}

