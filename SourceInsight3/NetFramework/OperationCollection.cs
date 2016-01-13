public class OperationCollection : ServiceDescriptionBaseCollection, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public int Add(Operation operation) {}
	public void Insert(int index, Operation operation) {}
	public int IndexOf(Operation operation) {}
	public bool Contains(Operation operation) {}
	public void Remove(Operation operation) {}
	public void CopyTo(Operation[] array, int index) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Operation Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

