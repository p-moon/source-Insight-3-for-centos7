public class DataGridViewSelectedCellCollection : BaseCollection, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
{

	// Methods
	public void Clear() {}
	public bool Contains(DataGridViewCell dataGridViewCell) {}
	public void CopyTo(DataGridViewCell[] array, int index) {}
	public void Insert(int index, DataGridViewCell dataGridViewCell) {}
	public virtual void CopyTo(System.Array ar, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DataGridViewCell Item { get{} }
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}

