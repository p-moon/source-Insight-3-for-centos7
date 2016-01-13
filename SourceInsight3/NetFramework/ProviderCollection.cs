public class ProviderCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ProviderCollection() {}

	// Methods
	public virtual void Add(ProviderBase provider) {}
	public void Remove(string name) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void SetReadOnly() {}
	public void Clear() {}
	public void CopyTo(ProviderBase[] array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ProviderBase Item { get{} }
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}

