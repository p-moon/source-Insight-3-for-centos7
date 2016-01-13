public class ServiceCollection : ServiceDescriptionBaseCollection, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public int Add(Service service) {}
	public void Insert(int index, Service service) {}
	public int IndexOf(Service service) {}
	public bool Contains(Service service) {}
	public void Remove(Service service) {}
	public void CopyTo(Service[] array, int index) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Service Item { get{} set{} }
	public Service Item { get{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

