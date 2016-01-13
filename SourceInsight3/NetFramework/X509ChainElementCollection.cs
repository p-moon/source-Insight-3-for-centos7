public class X509ChainElementCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public X509ChainElementEnumerator GetEnumerator() {}
	public void CopyTo(X509ChainElement[] array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public X509ChainElement Item { get{} }
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}

