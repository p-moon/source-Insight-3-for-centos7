public class Collection<T> : IList<T>, ICollection<T>, IEnumerable<T>, System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection
{

	// Constructors
	public Collection() {}
	public Collection(IList<T> list) {}

	// Methods
	public virtual void Add(T item) {}
	public virtual void Clear() {}
	public virtual void CopyTo(T[] array, int index) {}
	public virtual bool Contains(T item) {}
	public virtual IEnumerator<T> GetEnumerator() {}
	public virtual int IndexOf(T item) {}
	public virtual void Insert(int index, T item) {}
	public virtual bool Remove(T item) {}
	public virtual void RemoveAt(int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public T Item { get{} set{} }
}

