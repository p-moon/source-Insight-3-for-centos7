public class KeyCollection<TKey,TValue> : ICollection<TKey>, IEnumerable<TKey>, System.Collections.IEnumerable, System.Collections.ICollection
{

	// Constructors
	public KeyCollection(Dictionary<TKey,TValue> dictionary) {}

	// Methods
	public Enumerator<TKey,TValue> GetEnumerator() {}
	public virtual void CopyTo(TKey[] array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
}

