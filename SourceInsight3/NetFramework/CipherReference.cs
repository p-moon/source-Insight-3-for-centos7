public class CipherReference : EncryptedReference
{

	// Constructors
	public CipherReference() {}
	public CipherReference(string uri) {}
	public CipherReference(string uri, TransformChain transformChain) {}

	// Methods
	public virtual System.Xml.XmlElement GetXml() {}
	public virtual void LoadXml(System.Xml.XmlElement value) {}
	public void AddTransform(Transform transform) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Uri { get{} set{} }
	public TransformChain TransformChain { get{} set{} }
}

