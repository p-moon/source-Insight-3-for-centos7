public class SoapQName : ISoapXsd
{

	// Constructors
	public SoapQName() {}
	public SoapQName(string value) {}
	public SoapQName(string key, string name) {}
	public SoapQName(string key, string name, string namespaceValue) {}

	// Methods
	public virtual string GetXsdType() {}
	public virtual string ToString() {}
	public static SoapQName Parse(string value) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string XsdType { get{} }
	public string Name { get{} set{} }
	public string Namespace { get{} set{} }
	public string Key { get{} set{} }
}

