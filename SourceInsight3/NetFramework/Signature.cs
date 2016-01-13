public class Signature
{

	// Constructors
	public Signature() {}

	// Methods
	public System.Xml.XmlElement GetXml() {}
	public void LoadXml(System.Xml.XmlElement value) {}
	public void AddObject(DataObject dataObject) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Id { get{} set{} }
	public SignedInfo SignedInfo { get{} set{} }
	public byte[] SignatureValue { get{} set{} }
	public KeyInfo KeyInfo { get{} set{} }
	public System.Collections.IList ObjectList { get{} set{} }
}

