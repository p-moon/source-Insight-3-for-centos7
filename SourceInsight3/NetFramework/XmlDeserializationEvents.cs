public class XmlDeserializationEvents : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public XmlNodeEventHandler OnUnknownNode { get{} set{} }
	public XmlAttributeEventHandler OnUnknownAttribute { get{} set{} }
	public XmlElementEventHandler OnUnknownElement { get{} set{} }
	public UnreferencedObjectEventHandler OnUnreferencedObject { get{} set{} }
}

