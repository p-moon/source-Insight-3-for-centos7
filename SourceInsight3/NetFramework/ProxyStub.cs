public class ProxyStub
{

	// Constructors
	public ProxyStub() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string BaseInterface { get{} }
	public string IID { get{} }
	public string Name { get{} }
	public string NumMethods { get{} }
	public string TlbId { get{} }
	public string XmlBaseInterface { get{} set{} }
	public string XmlIID { get{} set{} }
	public string XmlName { get{} set{} }
	public string XmlNumMethods { get{} set{} }
	public string XmlTlbId { get{} set{} }
}

