public class LinkedListNode<T>
{

	// Constructors
	public LinkedListNode(T value) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public LinkedList<T> List { get{} }
	public LinkedListNode<T> Next { get{} }
	public LinkedListNode<T> Previous { get{} }
	public T Value { get{} set{} }
}

