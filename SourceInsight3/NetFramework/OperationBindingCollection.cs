public class OperationBindingCollection : ServiceDescriptionBaseCollection, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public int Add(OperationBinding bindingOperation) {}
	public void Insert(int index, OperationBinding bindingOperation) {}
	public int IndexOf(OperationBinding bindingOperation) {}
	public bool Contains(OperationBinding bindingOperation) {}
	public void Remove(OperationBinding bindingOperation) {}
	public void CopyTo(OperationBinding[] array, int index) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public OperationBinding Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

