public class Queue<T> : IEnumerable<T>, System.Collections.IEnumerable, System.Collections.ICollection
{

	// Constructors
	public Queue() {}
	public Queue(int capacity) {}
	public Queue(IEnumerable<T> collection) {}

	// Methods
	public void Clear() {}
	public void CopyTo(T[] array, int arrayIndex) {}
	public void Enqueue(T item) {}
	public Enumerator<T> GetEnumerator() {}
	public T Dequeue() {}
	public T Peek() {}
	public bool Contains(T item) {}
	public T[] ToArray() {}
	public void TrimExcess() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
}

