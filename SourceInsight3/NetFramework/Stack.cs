public class Stack : ICollection, IEnumerable, System.ICloneable
{

	// Constructors
	public Stack() {}
	public Stack(int initialCapacity) {}
	public Stack(ICollection col) {}

	// Methods
	public virtual void Clear() {}
	public virtual object Clone() {}
	public virtual bool Contains(object obj) {}
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual IEnumerator GetEnumerator() {}
	public virtual object Peek() {}
	public virtual object Pop() {}
	public virtual void Push(object obj) {}
	public static Stack Synchronized(Stack stack) {}
	public virtual object[] ToArray() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}

