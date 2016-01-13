public class XsltArgumentList
{

	// Constructors
	public XsltArgumentList() {}

	// Methods
	public object GetParam(string name, string namespaceUri) {}
	public object GetExtensionObject(string namespaceUri) {}
	public void AddParam(string name, string namespaceUri, object parameter) {}
	public void AddExtensionObject(string namespaceUri, object extension) {}
	public object RemoveParam(string name, string namespaceUri) {}
	public object RemoveExtensionObject(string namespaceUri) {}
	public void Clear() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Events
	public event System.Xml.Xsl.XsltMessageEncounteredEventHandler XsltMessageEncountered;
}

