public class BaseChannelObjectWithProperties : System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public virtual bool Contains(object key) {}
	public virtual void Add(object key, object value) {}
	public virtual void Clear() {}
	public virtual void Remove(object key) {}
	public virtual System.Collections.IDictionaryEnumerator GetEnumerator() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.IDictionary Properties { get{} }
	public object Item { get{} set{} }
	public System.Collections.ICollection Keys { get{} }
	public System.Collections.ICollection Values { get{} }
	public bool IsReadOnly { get{} }
	public bool IsFixedSize { get{} }
	public int Count { get{} }
	public object SyncRoot { get{} }
	public bool IsSynchronized { get{} }
}

