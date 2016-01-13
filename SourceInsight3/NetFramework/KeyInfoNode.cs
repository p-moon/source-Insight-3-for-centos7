public class KeyInfoNode : KeyInfoClause
{

	// Constructors
	public KeyInfoNode() {}
	public KeyInfoNode(System.Xml.XmlElement node) {}

	// Methods
	public virtual System.Xml.XmlElement GetXml() {}
	public virtual void LoadXml(System.Xml.XmlElement value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Xml.XmlElement Value { get{} set{} }
}

