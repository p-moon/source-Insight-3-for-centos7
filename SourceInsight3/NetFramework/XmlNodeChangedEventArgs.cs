public class XmlNodeChangedEventArgs : System.EventArgs
{

	// Constructors
	public XmlNodeChangedEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public XmlNodeChangedAction Action { get{} }
	public XmlNode Node { get{} }
	public XmlNode OldParent { get{} }
	public XmlNode NewParent { get{} }
	public string OldValue { get{} }
	public string NewValue { get{} }
}

