public class ParenthesizePropertyNameAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ParenthesizePropertyNameAttribute() {}
	public ParenthesizePropertyNameAttribute(bool needParenthesis) {}

	// Methods
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public ParenthesizePropertyNameAttribute Default;

	// Properties
	public bool NeedParenthesis { get{} }
	public object TypeId { get{} }
}

