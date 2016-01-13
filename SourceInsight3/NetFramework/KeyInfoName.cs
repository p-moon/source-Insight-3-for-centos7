public class KeyInfoName : KeyInfoClause
{

	// Constructors
	public KeyInfoName() {}
	public KeyInfoName(string keyName) {}

	// Methods
	public virtual System.Xml.XmlElement GetXml() {}
	public virtual void LoadXml(System.Xml.XmlElement value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Value { get{} set{} }
}

