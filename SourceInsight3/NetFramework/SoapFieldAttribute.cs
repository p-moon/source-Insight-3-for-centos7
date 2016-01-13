public class SoapFieldAttribute : SoapAttribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public SoapFieldAttribute() {}

	// Methods
	public bool IsInteropXmlElement() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string XmlElementName { get{} set{} }
	public int Order { get{} set{} }
	public string XmlNamespace { get{} set{} }
	public bool UseAttribute { get{} set{} }
	public bool Embedded { get{} set{} }
	public object TypeId { get{} }
}

