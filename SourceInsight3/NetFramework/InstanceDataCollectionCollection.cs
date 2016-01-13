public class InstanceDataCollectionCollection : System.Collections.DictionaryBase, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public InstanceDataCollectionCollection() {}

	// Methods
	public bool Contains(string counterName) {}
	public void CopyTo(InstanceDataCollection[] counters, int index) {}
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual void Clear() {}
	public virtual System.Collections.IDictionaryEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public InstanceDataCollection Item { get{} }
	public System.Collections.ICollection Keys { get{} }
	public System.Collections.ICollection Values { get{} }
	public int Count { get{} }
}

