public class Transform
{

	// Methods
	public System.Xml.XmlElement GetXml() {}
	public abstract virtual void LoadInnerXml(System.Xml.XmlNodeList nodeList) {}
	public abstract virtual void LoadInput(object obj) {}
	public abstract virtual object GetOutput() {}
	public abstract virtual object GetOutput(Type type) {}
	public virtual byte[] GetDigestedOutput(System.Security.Cryptography.HashAlgorithm hash) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Algorithm { get{} set{} }
	public System.Xml.XmlResolver Resolver { set{} }
	public Type[] InputTypes { get{} }
	public Type[] OutputTypes { get{} }
	public System.Xml.XmlElement Context { get{} set{} }
	public System.Collections.Hashtable PropagatedNamespaces { get{} }
}

