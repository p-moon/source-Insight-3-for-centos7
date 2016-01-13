public class DataSourceDescriptorCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public DataSourceDescriptorCollection() {}

	// Methods
	public int Add(DataSourceDescriptor value) {}
	public int IndexOf(DataSourceDescriptor value) {}
	public void Insert(int index, DataSourceDescriptor value) {}
	public bool Contains(DataSourceDescriptor value) {}
	public void CopyTo(DataSourceDescriptor[] array, int index) {}
	public void Remove(DataSourceDescriptor value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DataSourceDescriptor Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

