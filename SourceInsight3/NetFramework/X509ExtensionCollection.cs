public class X509ExtensionCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public X509ExtensionCollection() {}

	// Methods
	public int Add(X509Extension extension) {}
	public X509ExtensionEnumerator GetEnumerator() {}
	public void CopyTo(X509Extension[] array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public X509Extension Item { get{} }
	public X509Extension Item { get{} }
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}

