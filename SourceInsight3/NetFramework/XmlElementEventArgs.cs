public class XmlElementEventArgs : System.EventArgs
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object ObjectBeingDeserialized { get{} }
	public System.Xml.XmlElement Element { get{} }
	public int LineNumber { get{} }
	public int LinePosition { get{} }
	public string ExpectedElements { get{} }
}

