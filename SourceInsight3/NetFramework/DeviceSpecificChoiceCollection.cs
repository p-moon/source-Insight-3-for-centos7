public class DeviceSpecificChoiceCollection : ArrayListCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public void Add(DeviceSpecificChoice choice) {}
	public void AddAt(int index, DeviceSpecificChoice choice) {}
	public void Clear() {}
	public void RemoveAt(int index) {}
	public void Remove(DeviceSpecificChoice choice) {}
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DeviceSpecificChoice Item { get{} }
	public System.Collections.ArrayList All { get{} }
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}

