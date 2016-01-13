public class Reference
{

	// Constructors
	public Reference() {}
	public Reference(System.IO.Stream stream) {}
	public Reference(string uri) {}

	// Methods
	public System.Xml.XmlElement GetXml() {}
	public void LoadXml(System.Xml.XmlElement value) {}
	public void AddTransform(Transform transform) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Id { get{} set{} }
	public string Uri { get{} set{} }
	public string Type { get{} set{} }
	public string DigestMethod { get{} set{} }
	public byte[] DigestValue { get{} set{} }
	public TransformChain TransformChain { get{} set{} }
}

