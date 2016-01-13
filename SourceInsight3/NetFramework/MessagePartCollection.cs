public class MessagePartCollection : ServiceDescriptionBaseCollection, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public int Add(MessagePart messagePart) {}
	public void Insert(int index, MessagePart messagePart) {}
	public int IndexOf(MessagePart messagePart) {}
	public bool Contains(MessagePart messagePart) {}
	public void Remove(MessagePart messagePart) {}
	public void CopyTo(MessagePart[] array, int index) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MessagePart Item { get{} set{} }
	public MessagePart Item { get{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

