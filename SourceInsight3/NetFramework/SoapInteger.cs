public class SoapInteger : ISoapXsd
{

	// Constructors
	public SoapInteger() {}
	public SoapInteger(decimal value) {}

	// Methods
	public virtual string GetXsdType() {}
	public virtual string ToString() {}
	public static SoapInteger Parse(string value) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string XsdType { get{} }
	public decimal Value { get{} set{} }
}

