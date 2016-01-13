public class DataReference : EncryptedReference
{

	// Constructors
	public DataReference() {}
	public DataReference(string uri) {}
	public DataReference(string uri, TransformChain transformChain) {}

	// Methods
	public void AddTransform(Transform transform) {}
	public virtual System.Xml.XmlElement GetXml() {}
	public virtual void LoadXml(System.Xml.XmlElement value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Uri { get{} set{} }
	public TransformChain TransformChain { get{} set{} }
}

