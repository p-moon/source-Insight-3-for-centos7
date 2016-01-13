public class ValidationEventArgs : System.EventArgs
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public XmlSeverityType Severity { get{} }
	public XmlSchemaException Exception { get{} }
	public string Message { get{} }
}

