public class DiscoveryClientReferenceCollection : System.Collections.DictionaryBase, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public DiscoveryClientReferenceCollection() {}

	// Methods
	public void Add(DiscoveryReference value) {}
	public void Add(string url, DiscoveryReference value) {}
	public bool Contains(string url) {}
	public void Remove(string url) {}
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual void Clear() {}
	public virtual System.Collections.IDictionaryEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DiscoveryReference Item { get{} set{} }
	public System.Collections.ICollection Keys { get{} }
	public System.Collections.ICollection Values { get{} }
	public int Count { get{} }
}

