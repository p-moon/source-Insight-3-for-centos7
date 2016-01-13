public class EncryptionMethod
{

	// Constructors
	public EncryptionMethod() {}
	public EncryptionMethod(string algorithm) {}

	// Methods
	public System.Xml.XmlElement GetXml() {}
	public void LoadXml(System.Xml.XmlElement value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int KeySize { get{} set{} }
	public string KeyAlgorithm { get{} set{} }
}

