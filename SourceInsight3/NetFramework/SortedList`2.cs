public class SortedList<TKey,TValue> : IDictionary<TKey,TValue>, ICollection<KeyValuePair<TKey,TValue>>, IEnumerable<KeyValuePair<TKey,TValue>>, System.Collections.IEnumerable, System.Collections.IDictionary, System.Collections.ICollection
{

	// Constructors
	public SortedList() {}
	public SortedList(int capacity) {}
	public SortedList(IComparer<TKey> comparer) {}
	public SortedList(int capacity, IComparer<TKey> comparer) {}
	public SortedList(IDictionary<TKey,TValue> dictionary) {}
	public SortedList(IDictionary<TKey,TValue> dictionary, IComparer<TKey> comparer) {}

	// Methods
	public virtual void Add(TKey key, TValue value) {}
	public int IndexOfKey(TKey key) {}
	public virtual bool TryGetValue(TKey keyout , TValue& value) {}
	public void RemoveAt(int index) {}
	public virtual bool Remove(TKey key) {}
	public virtual void Clear() {}
	public virtual bool ContainsKey(TKey key) {}
	public bool ContainsValue(TValue value) {}
	public IEnumerator<KeyValuePair<TKey,TValue>> GetEnumerator() {}
	public int IndexOfValue(TValue value) {}
	public void TrimExcess() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Capacity { get{} set{} }
	public IComparer<TKey> Comparer { get{} }
	public int Count { get{} }
	public IList<TKey> Keys { get{} }
	public IList<TValue> Values { get{} }
	public TValue Item { get{} set{} }
}

