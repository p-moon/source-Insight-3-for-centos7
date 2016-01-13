public class SoapParameterAttribute : SoapAttribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public SoapParameterAttribute() {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string XmlNamespace { get{} set{} }
	public bool UseAttribute { get{} set{} }
	public bool Embedded { get{} set{} }
	public object TypeId { get{} }
}

