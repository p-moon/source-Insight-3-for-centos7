public class X509ChainElement
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public X509Certificate2 Certificate { get{} }
	public X509ChainStatus[] ChainElementStatus { get{} }
	public string Information { get{} }
}

