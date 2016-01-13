public class PortTypeCollection : ServiceDescriptionBaseCollection, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public int Add(PortType portType) {}
	public void Insert(int index, PortType portType) {}
	public int IndexOf(PortType portType) {}
	public bool Contains(PortType portType) {}
	public void Remove(PortType portType) {}
	public void CopyTo(PortType[] array, int index) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public PortType Item { get{} set{} }
	public PortType Item { get{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

