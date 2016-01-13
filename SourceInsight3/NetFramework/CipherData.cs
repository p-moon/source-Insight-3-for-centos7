public class CipherData
{

	// Constructors
	public CipherData() {}
	public CipherData(byte[] cipherValue) {}
	public CipherData(CipherReference cipherReference) {}

	// Methods
	public System.Xml.XmlElement GetXml() {}
	public void LoadXml(System.Xml.XmlElement value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CipherReference CipherReference { get{} set{} }
	public byte[] CipherValue { get{} set{} }
}

