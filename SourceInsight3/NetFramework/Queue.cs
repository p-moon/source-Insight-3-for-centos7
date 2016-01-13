public class Queue : ICollection, IEnumerable, System.ICloneable
{

	// Constructors
	public Queue() {}
	public Queue(int capacity) {}
	public Queue(int capacity, float growFactor) {}
	public Queue(ICollection col) {}

	// Methods
	public virtual object Clone() {}
	public virtual void Clear() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual void Enqueue(object obj) {}
	public virtual IEnumerator GetEnumerator() {}
	public virtual object Dequeue() {}
	public virtual object Peek() {}
	public static Queue Synchronized(Queue queue) {}
	public virtual bool Contains(object obj) {}
	public virtual object[] ToArray() {}
	public virtual void TrimToSize() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}

