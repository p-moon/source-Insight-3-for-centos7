public class XmlSerializerImplementation
{

	// Methods
	public virtual bool CanSerialize(Type type) {}
	public virtual XmlSerializer GetSerializer(Type type) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public XmlSerializationReader Reader { get{} }
	public XmlSerializationWriter Writer { get{} }
	public System.Collections.Hashtable ReadMethods { get{} }
	public System.Collections.Hashtable WriteMethods { get{} }
	public System.Collections.Hashtable TypedSerializers { get{} }
}

