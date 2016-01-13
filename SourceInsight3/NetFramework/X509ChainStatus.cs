public class X509ChainStatus : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public X509ChainStatusFlags Status { get{} set{} }
	public string StatusInformation { get{} set{} }
}

