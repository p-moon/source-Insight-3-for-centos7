public class DictionaryBase : IDictionary, ICollection, IEnumerable
{

	// Methods
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual void Clear() {}
	public virtual IDictionaryEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
}

