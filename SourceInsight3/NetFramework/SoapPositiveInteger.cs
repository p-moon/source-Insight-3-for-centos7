public class SoapPositiveInteger : ISoapXsd
{

	// Constructors
	public SoapPositiveInteger() {}
	public SoapPositiveInteger(decimal value) {}

	// Methods
	public virtual string GetXsdType() {}
	public virtual string ToString() {}
	public static SoapPositiveInteger Parse(string value) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string XsdType { get{} }
	public decimal Value { get{} set{} }
}

