public interface IList<T> : ICollection<T>, IEnumerable<T>, System.Collections.IEnumerable
{

	// Methods
	public abstract virtual int IndexOf(T item) {}
	public abstract virtual void Insert(int index, T item) {}
	public abstract virtual void RemoveAt(int index) {}

	// Properties
	public T Item { get{} set{} }
}

