public class PersonalizationDictionary : System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public PersonalizationDictionary() {}
	public PersonalizationDictionary(int initialSize) {}

	// Methods
	public virtual void Add(string key, PersonalizationEntry value) {}
	public virtual void Clear() {}
	public virtual bool Contains(string key) {}
	public virtual void CopyTo(System.Collections.DictionaryEntry[] array, int index) {}
	public virtual System.Collections.IDictionaryEnumerator GetEnumerator() {}
	public virtual void Remove(string key) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsFixedSize { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
	public System.Collections.ICollection Keys { get{} }
	public object SyncRoot { get{} }
	public System.Collections.ICollection Values { get{} }
	public PersonalizationEntry Item { get{} set{} }
}

