public class SoapMethodAttribute : SoapAttribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public SoapMethodAttribute() {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string SoapAction { get{} set{} }
	public bool UseAttribute { get{} set{} }
	public string XmlNamespace { get{} set{} }
	public string ResponseXmlElementName { get{} set{} }
	public string ResponseXmlNamespace { get{} set{} }
	public string ReturnXmlElementName { get{} set{} }
	public bool Embedded { get{} set{} }
	public object TypeId { get{} }
}

