public class XmlDecryptionTransform : Transform
{

	// Constructors
	public XmlDecryptionTransform() {}

	// Methods
	public void AddExceptUri(string uri) {}
	public virtual void LoadInnerXml(System.Xml.XmlNodeList nodeList) {}
	public virtual void LoadInput(object obj) {}
	public virtual object GetOutput() {}
	public virtual object GetOutput(Type type) {}
	public System.Xml.XmlElement GetXml() {}
	public virtual byte[] GetDigestedOutput(System.Security.Cryptography.HashAlgorithm hash) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public EncryptedXml EncryptedXml { get{} set{} }
	public Type[] InputTypes { get{} }
	public Type[] OutputTypes { get{} }
	public string Algorithm { get{} set{} }
	public System.Xml.XmlResolver Resolver { set{} }
	public System.Xml.XmlElement Context { get{} set{} }
	public System.Collections.Hashtable PropagatedNamespaces { get{} }
}

