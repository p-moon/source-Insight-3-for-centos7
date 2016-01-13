public class OperationMessageCollection : ServiceDescriptionBaseCollection, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public int Add(OperationMessage operationMessage) {}
	public void Insert(int index, OperationMessage operationMessage) {}
	public int IndexOf(OperationMessage operationMessage) {}
	public bool Contains(OperationMessage operationMessage) {}
	public void Remove(OperationMessage operationMessage) {}
	public void CopyTo(OperationMessage[] array, int index) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public OperationMessage Item { get{} set{} }
	public OperationInput Input { get{} }
	public OperationOutput Output { get{} }
	public OperationFlow Flow { get{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

