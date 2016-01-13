public class Dictionary<TKey,TValue> : IDictionary<TKey,TValue>, ICollection<KeyValuePair<TKey,TValue>>, IEnumerable<KeyValuePair<TKey,TValue>>, System.Collections.IEnumerable, System.Collections.IDictionary, System.Collections.ICollection, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
{

	// Constructors
	public Dictionary(int capacity, IEqualityComparer<TKey> comparer) {}
	public Dictionary() {}
	public Dictionary(int capacity) {}
	public Dictionary(IEqualityComparer<TKey> comparer) {}
	public Dictionary(IDictionary<TKey,TValue> dictionary) {}
	public Dictionary(IDictionary<TKey,TValue> dictionary, IEqualityComparer<TKey> comparer) {}

	// Methods
	public virtual void Add(TKey key, TValue value) {}
	public virtual void Clear() {}
	public virtual bool ContainsKey(TKey key) {}
	public bool ContainsValue(TValue value) {}
	public Enumerator<TKey,TValue> GetEnumerator() {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual void OnDeserialization(object sender) {}
	public virtual bool Remove(TKey key) {}
	public virtual bool TryGetValue(TKey keyout , TValue& value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public IEqualityComparer<TKey> Comparer { get{} }
	public int Count { get{} }
	public KeyCollection<TKey,TValue> Keys { get{} }
	public ValueCollection<TKey,TValue> Values { get{} }
	public TValue Item { get{} set{} }
}

