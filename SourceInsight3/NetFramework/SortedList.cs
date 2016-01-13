public class SortedList : IDictionary, ICollection, IEnumerable, System.ICloneable
{

	// Constructors
	public SortedList() {}
	public SortedList(int initialCapacity) {}
	public SortedList(IComparer comparer) {}
	public SortedList(IComparer comparer, int capacity) {}
	public SortedList(IDictionary d) {}
	public SortedList(IDictionary d, IComparer comparer) {}

	// Methods
	public virtual void Add(object key, object value) {}
	public virtual void Clear() {}
	public virtual object Clone() {}
	public virtual bool Contains(object key) {}
	public virtual bool ContainsKey(object key) {}
	public virtual bool ContainsValue(object value) {}
	public virtual void CopyTo(System.Array array, int arrayIndex) {}
	public virtual object GetByIndex(int index) {}
	public virtual IDictionaryEnumerator GetEnumerator() {}
	public virtual object GetKey(int index) {}
	public virtual IList GetKeyList() {}
	public virtual IList GetValueList() {}
	public virtual int IndexOfKey(object key) {}
	public virtual int IndexOfValue(object value) {}
	public virtual void RemoveAt(int index) {}
	public virtual void Remove(object key) {}
	public virtual void SetByIndex(int index, object value) {}
	public static SortedList Synchronized(SortedList list) {}
	public virtual void TrimToSize() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Capacity { get{} set{} }
	public int Count { get{} }
	public ICollection Keys { get{} }
	public ICollection Values { get{} }
	public bool IsReadOnly { get{} }
	public bool IsFixedSize { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
	public object Item { get{} set{} }
}

