public class XmlDsigExcC14NWithCommentsTransform : XmlDsigExcC14NTransform
{

	// Constructors
	public XmlDsigExcC14NWithCommentsTransform() {}
	public XmlDsigExcC14NWithCommentsTransform(string inclusiveNamespacesPrefixList) {}

	// Methods
	public virtual void LoadInnerXml(System.Xml.XmlNodeList nodeList) {}
	public virtual void LoadInput(object obj) {}
	public virtual object GetOutput() {}
	public virtual object GetOutput(Type type) {}
	public virtual byte[] GetDigestedOutput(System.Security.Cryptography.HashAlgorithm hash) {}
	public System.Xml.XmlElement GetXml() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string InclusiveNamespacesPrefixList { get{} set{} }
	public Type[] InputTypes { get{} }
	public Type[] OutputTypes { get{} }
	public string Algorithm { get{} set{} }
	public System.Xml.XmlResolver Resolver { set{} }
	public System.Xml.XmlElement Context { get{} set{} }
	public System.Collections.Hashtable PropagatedNamespaces { get{} }
}

