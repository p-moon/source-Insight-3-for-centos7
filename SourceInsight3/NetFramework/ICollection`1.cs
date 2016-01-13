public interface ICollection<T> : IEnumerable<T>, System.Collections.IEnumerable
{

	// Methods
	public abstract virtual void Add(T item) {}
	public abstract virtual void Clear() {}
	public abstract virtual bool Contains(T item) {}
	public abstract virtual void CopyTo(T[] array, int arrayIndex) {}
	public abstract virtual bool Remove(T item) {}

	// Properties
	public int Count { get{} }
	public bool IsReadOnly { get{} }
}

