public class XsltSettings
{

	// Constructors
	public XsltSettings() {}
	public XsltSettings(bool enableDocumentFunction, bool enableScript) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public XsltSettings Default { get{} }
	public XsltSettings TrustedXslt { get{} }
	public bool EnableDocumentFunction { get{} set{} }
	public bool EnableScript { get{} set{} }
}

