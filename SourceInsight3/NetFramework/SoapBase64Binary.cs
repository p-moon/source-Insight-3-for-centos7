public class SoapBase64Binary : ISoapXsd
{

	// Constructors
	public SoapBase64Binary() {}
	public SoapBase64Binary(byte[] value) {}

	// Methods
	public virtual string GetXsdType() {}
	public virtual string ToString() {}
	public static SoapBase64Binary Parse(string value) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string XsdType { get{} }
	public byte[] Value { get{} set{} }
}

