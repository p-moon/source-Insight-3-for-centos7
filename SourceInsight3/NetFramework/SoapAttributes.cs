public class SoapAttributes
{

	// Constructors
	public SoapAttributes() {}
	public SoapAttributes(System.Reflection.ICustomAttributeProvider provider) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SoapTypeAttribute SoapType { get{} set{} }
	public SoapEnumAttribute SoapEnum { get{} set{} }
	public bool SoapIgnore { get{} set{} }
	public SoapElementAttribute SoapElement { get{} set{} }
	public SoapAttributeAttribute SoapAttribute { get{} set{} }
	public object SoapDefaultValue { get{} set{} }
}

