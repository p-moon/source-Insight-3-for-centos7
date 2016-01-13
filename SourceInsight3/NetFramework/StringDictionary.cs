public class StringDictionary : System.Collections.IEnumerable
{

	// Constructors
	public StringDictionary() {}

	// Methods
	public virtual void Add(string key, string value) {}
	public virtual void Clear() {}
	public virtual bool ContainsKey(string key) {}
	public virtual bool ContainsValue(string value) {}
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual void Remove(string key) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public string Item { get{} set{} }
	public System.Collections.ICollection Keys { get{} }
	public object SyncRoot { get{} }
	public System.Collections.ICollection Values { get{} }
}

