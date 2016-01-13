public class XmlChoiceIdentifierAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public XmlChoiceIdentifierAttribute() {}
	public XmlChoiceIdentifierAttribute(string name) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string MemberName { get{} set{} }
	public object TypeId { get{} }
}

