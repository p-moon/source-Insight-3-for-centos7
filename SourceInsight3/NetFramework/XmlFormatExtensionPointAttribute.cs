public class XmlFormatExtensionPointAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public XmlFormatExtensionPointAttribute(string memberName) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string MemberName { get{} set{} }
	public bool AllowElements { get{} set{} }
	public object TypeId { get{} }
}

