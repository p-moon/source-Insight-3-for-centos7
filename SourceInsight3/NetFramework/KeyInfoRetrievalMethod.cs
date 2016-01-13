public class KeyInfoRetrievalMethod : KeyInfoClause
{

	// Constructors
	public KeyInfoRetrievalMethod() {}
	public KeyInfoRetrievalMethod(string strUri) {}
	public KeyInfoRetrievalMethod(string strUri, string typeName) {}

	// Methods
	public virtual System.Xml.XmlElement GetXml() {}
	public virtual void LoadXml(System.Xml.XmlElement value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Uri { get{} set{} }
	public string Type { get{} set{} }
}

