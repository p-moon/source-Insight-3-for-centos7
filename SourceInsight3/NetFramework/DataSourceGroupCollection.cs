public class DataSourceGroupCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public DataSourceGroupCollection() {}

	// Methods
	public int Add(DataSourceGroup value) {}
	public int IndexOf(DataSourceGroup value) {}
	public void Insert(int index, DataSourceGroup value) {}
	public bool Contains(DataSourceGroup value) {}
	public void CopyTo(DataSourceGroup[] array, int index) {}
	public void Remove(DataSourceGroup value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DataSourceGroup Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

