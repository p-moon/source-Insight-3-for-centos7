public class LinkedList<T> : ICollection<T>, IEnumerable<T>, System.Collections.IEnumerable, System.Collections.ICollection, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
{

	// Constructors
	public LinkedList() {}
	public LinkedList(IEnumerable<T> collection) {}

	// Methods
	public LinkedListNode<T> AddAfter(LinkedListNode<T> node, T value) {}
	public void AddAfter(LinkedListNode<T> node, LinkedListNode<T> newNode) {}
	public LinkedListNode<T> AddBefore(LinkedListNode<T> node, T value) {}
	public void AddBefore(LinkedListNode<T> node, LinkedListNode<T> newNode) {}
	public LinkedListNode<T> AddFirst(T value) {}
	public void AddFirst(LinkedListNode<T> node) {}
	public LinkedListNode<T> AddLast(T value) {}
	public void AddLast(LinkedListNode<T> node) {}
	public LinkedListNode<T> Find(T value) {}
	public LinkedListNode<T> FindLast(T value) {}
	public Enumerator<T> GetEnumerator() {}
	public void Remove(LinkedListNode<T> node) {}
	public void RemoveFirst() {}
	public void RemoveLast() {}
	public virtual void Clear() {}
	public virtual bool Contains(T value) {}
	public virtual void CopyTo(T[] array, int index) {}
	public virtual bool Remove(T value) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual void OnDeserialization(object sender) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public LinkedListNode<T> First { get{} }
	public LinkedListNode<T> Last { get{} }
}

