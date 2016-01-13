public class XmlFormatExtensionPrefixAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public XmlFormatExtensionPrefixAttribute() {}
	public XmlFormatExtensionPrefixAttribute(string prefix, string ns) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Prefix { get{} set{} }
	public string Namespace { get{} set{} }
	public object TypeId { get{} }
}

