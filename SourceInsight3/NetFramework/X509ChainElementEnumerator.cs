public class X509ChainElementEnumerator : System.Collections.IEnumerator
{

	// Methods
	public virtual bool MoveNext() {}
	public virtual void Reset() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public X509ChainElement Current { get{} }
}

