public class X509Chain
{

	// Constructors
	public X509Chain() {}
	public X509Chain(bool useMachineContext) {}
	public X509Chain(System.IntPtr chainContext) {}

	// Methods
	public static X509Chain Create() {}
	public bool Build(X509Certificate2 certificate) {}
	public void Reset() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.IntPtr ChainContext { get{} }
	public X509ChainPolicy ChainPolicy { get{} set{} }
	public X509ChainStatus[] ChainStatus { get{} }
	public X509ChainElementCollection ChainElements { get{} }
}

