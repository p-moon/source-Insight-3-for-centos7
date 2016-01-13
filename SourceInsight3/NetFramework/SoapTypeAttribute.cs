public class SoapTypeAttribute : SoapAttribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public SoapTypeAttribute() {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public SoapOption SoapOptions { get{} set{} }
	public string XmlElementName { get{} set{} }
	public string XmlNamespace { get{} set{} }
	public string XmlTypeName { get{} set{} }
	public string XmlTypeNamespace { get{} set{} }
	public XmlFieldOrderOption XmlFieldOrder { get{} set{} }
	public bool UseAttribute { get{} set{} }
	public bool Embedded { get{} set{} }
	public object TypeId { get{} }
}

