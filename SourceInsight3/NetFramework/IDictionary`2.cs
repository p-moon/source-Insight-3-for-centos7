public interface IDictionary<TKey,TValue> : ICollection<KeyValuePair<TKey,TValue>>, IEnumerable<KeyValuePair<TKey,TValue>>, System.Collections.IEnumerable
{

	// Methods
	public abstract virtual bool ContainsKey(TKey key) {}
	public abstract virtual void Add(TKey key, TValue value) {}
	public abstract virtual bool Remove(TKey key) {}
	public abstract virtual bool TryGetValue(TKey keyout , TValue& value) {}

	// Properties
	public TValue Item { get{} set{} }
	public ICollection<TKey> Keys { get{} }
	public ICollection<TValue> Values { get{} }
}

