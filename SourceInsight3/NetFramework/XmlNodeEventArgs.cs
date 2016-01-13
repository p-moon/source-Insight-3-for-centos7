public class XmlNodeEventArgs : System.EventArgs
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object ObjectBeingDeserialized { get{} }
	public System.Xml.XmlNodeType NodeType { get{} }
	public string Name { get{} }
	public string LocalName { get{} }
	public string NamespaceURI { get{} }
	public string Text { get{} }
	public int LineNumber { get{} }
	public int LinePosition { get{} }
}

