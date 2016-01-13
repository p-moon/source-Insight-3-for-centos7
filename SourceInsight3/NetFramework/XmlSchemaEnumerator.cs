public class XmlSchemaEnumerator : IEnumerator<System.Xml.Schema.XmlSchema>, System.IDisposable, System.Collections.IEnumerator
{

	// Constructors
	public XmlSchemaEnumerator(XmlSchemas list) {}

	// Methods
	public virtual void Dispose() {}
	public virtual bool MoveNext() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Xml.Schema.XmlSchema Current { get{} }
}

