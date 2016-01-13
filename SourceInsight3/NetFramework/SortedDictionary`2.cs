public class SortedDictionary<TKey,TValue> : IDictionary<TKey,TValue>, ICollection<KeyValuePair<TKey,TValue>>, IEnumerable<KeyValuePair<TKey,TValue>>, System.Collections.IEnumerable, System.Collections.IDictionary, System.Collections.ICollection
{

	// Constructors
	public SortedDictionary() {}
	public SortedDictionary(IDictionary<TKey,TValue> dictionary) {}
	public SortedDictionary(IDictionary<TKey,TValue> dictionary, IComparer<TKey> comparer) {}
	public SortedDictionary(IComparer<TKey> comparer) {}

	// Methods
	public virtual void Add(TKey key, TValue value) {}
	public virtual void Clear() {}
	public virtual bool ContainsKey(TKey key) {}
	public bool ContainsValue(TValue value) {}
	public virtual void CopyTo(KeyValuePair<TKey,TValue>[] array, int index) {}
	public Enumerator<TKey,TValue> GetEnumerator() {}
	public virtual bool Remove(TKey key) {}
	public virtual bool TryGetValue(TKey keyout , TValue& value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public TValue Item { get{} set{} }
	public int Count { get{} }
	public IComparer<TKey> Comparer { get{} }
	public KeyCollection<TKey,TValue> Keys { get{} }
	public ValueCollection<TKey,TValue> Values { get{} }
}

