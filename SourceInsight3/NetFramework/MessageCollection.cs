public class MessageCollection : ServiceDescriptionBaseCollection, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public int Add(Message message) {}
	public void Insert(int index, Message message) {}
	public int IndexOf(Message message) {}
	public bool Contains(Message message) {}
	public void Remove(Message message) {}
	public void CopyTo(Message[] array, int index) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Message Item { get{} set{} }
	public Message Item { get{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

