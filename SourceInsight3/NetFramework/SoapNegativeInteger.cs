public class SoapNegativeInteger : ISoapXsd
{

	// Constructors
	public SoapNegativeInteger() {}
	public SoapNegativeInteger(decimal value) {}

	// Methods
	public virtual string GetXsdType() {}
	public virtual string ToString() {}
	public static SoapNegativeInteger Parse(string value) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string XsdType { get{} }
	public decimal Value { get{} set{} }
}

