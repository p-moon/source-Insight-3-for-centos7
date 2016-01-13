public class SoapHexBinary : ISoapXsd
{

	// Constructors
	public SoapHexBinary() {}
	public SoapHexBinary(byte[] value) {}

	// Methods
	public virtual string GetXsdType() {}
	public virtual string ToString() {}
	public static SoapHexBinary Parse(string value) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string XsdType { get{} }
	public byte[] Value { get{} set{} }
}

