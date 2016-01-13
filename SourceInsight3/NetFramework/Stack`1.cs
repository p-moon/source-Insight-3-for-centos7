public class Stack<T> : IEnumerable<T>, System.Collections.IEnumerable, System.Collections.ICollection
{

	// Constructors
	public Stack(int capacity) {}
	public Stack() {}
	public Stack(IEnumerable<T> collection) {}

	// Methods
	public T Pop() {}
	public void Clear() {}
	public bool Contains(T item) {}
	public void CopyTo(T[] array, int arrayIndex) {}
	public Enumerator<T> GetEnumerator() {}
	public void TrimExcess() {}
	public T Peek() {}
	public void Push(T item) {}
	public T[] ToArray() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
}

