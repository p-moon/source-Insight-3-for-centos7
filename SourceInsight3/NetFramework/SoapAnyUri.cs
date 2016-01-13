public class SoapAnyUri : ISoapXsd
{

	// Constructors
	public SoapAnyUri() {}
	public SoapAnyUri(string value) {}

	// Methods
	public virtual string GetXsdType() {}
	public virtual string ToString() {}
	public static SoapAnyUri Parse(string value) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string XsdType { get{} }
	public string Value { get{} set{} }
}

