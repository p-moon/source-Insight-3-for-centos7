public class X509CertificateEnumerator : System.Collections.IEnumerator
{

	// Constructors
	public X509CertificateEnumerator(X509CertificateCollection mappings) {}

	// Methods
	public bool MoveNext() {}
	public void Reset() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public X509Certificate Current { get{} }
}

