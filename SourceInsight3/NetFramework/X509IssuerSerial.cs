public class X509IssuerSerial : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public string IssuerName { get{} set{} }
	public string SerialNumber { get{} set{} }
}

