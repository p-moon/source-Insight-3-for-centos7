public class SoapIdrefs : ISoapXsd
{

	// Constructors
	public SoapIdrefs() {}
	public SoapIdrefs(string value) {}

	// Methods
	public virtual string GetXsdType() {}
	public virtual string ToString() {}
	public static SoapIdrefs Parse(string value) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string XsdType { get{} }
	public string Value { get{} set{} }
}

