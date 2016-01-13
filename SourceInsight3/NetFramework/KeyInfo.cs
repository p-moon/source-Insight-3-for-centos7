public class KeyInfo : System.Collections.IEnumerable
{

	// Constructors
	public KeyInfo() {}

	// Methods
	public System.Xml.XmlElement GetXml() {}
	public void LoadXml(System.Xml.XmlElement value) {}
	public void AddClause(KeyInfoClause clause) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public System.Collections.IEnumerator GetEnumerator(Type requestedObjectType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Id { get{} set{} }
	public int Count { get{} }
}

