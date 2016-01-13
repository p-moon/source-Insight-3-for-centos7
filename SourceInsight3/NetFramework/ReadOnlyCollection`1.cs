public class ReadOnlyCollection<T> : IList<T>, ICollection<T>, IEnumerable<T>, System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection
{

	// Constructors
	public ReadOnlyCollection(IList<T> list) {}

	// Methods
	public virtual bool Contains(T value) {}
	public virtual void CopyTo(T[] array, int index) {}
	public virtual IEnumerator<T> GetEnumerator() {}
	public virtual int IndexOf(T value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public T Item { get{} }
}

