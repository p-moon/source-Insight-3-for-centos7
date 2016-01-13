public class ValueCollection<TKey,TValue> : ICollection<TValue>, IEnumerable<TValue>, System.Collections.IEnumerable, System.Collections.ICollection
{

	// Constructors
	public ValueCollection(SortedDictionary<TKey,TValue> dictionary) {}

	// Methods
	public Enumerator<TKey,TValue> GetEnumerator() {}
	public virtual void CopyTo(TValue[] array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
}

