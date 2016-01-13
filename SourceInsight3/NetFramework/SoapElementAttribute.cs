public class SoapElementAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public SoapElementAttribute() {}
	public SoapElementAttribute(string elementName) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string ElementName { get{} set{} }
	public string DataType { get{} set{} }
	public bool IsNullable { get{} set{} }
	public object TypeId { get{} }
}

