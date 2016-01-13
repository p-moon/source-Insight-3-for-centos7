public class PortCollection : ServiceDescriptionBaseCollection, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public int Add(Port port) {}
	public void Insert(int index, Port port) {}
	public int IndexOf(Port port) {}
	public bool Contains(Port port) {}
	public void Remove(Port port) {}
	public void CopyTo(Port[] array, int index) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Port Item { get{} set{} }
	public Port Item { get{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

