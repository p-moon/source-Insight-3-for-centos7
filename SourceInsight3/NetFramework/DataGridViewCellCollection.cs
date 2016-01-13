public class DataGridViewCellCollection : BaseCollection, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
{

	// Constructors
	public DataGridViewCellCollection(DataGridViewRow dataGridViewRow) {}

	// Methods
	public virtual int Add(DataGridViewCell dataGridViewCell) {}
	public virtual void AddRange(DataGridViewCell[] dataGridViewCells) {}
	public virtual void Clear() {}
	public void CopyTo(DataGridViewCell[] array, int index) {}
	public virtual bool Contains(DataGridViewCell dataGridViewCell) {}
	public int IndexOf(DataGridViewCell dataGridViewCell) {}
	public virtual void Insert(int index, DataGridViewCell dataGridViewCell) {}
	public virtual void Remove(DataGridViewCell cell) {}
	public virtual void RemoveAt(int index) {}
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
	public DataGridViewCell Item { get{} set{} }
	public DataGridViewCell Item { get{} set{} }
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }

	// Events
	public event System.ComponentModel.CollectionChangeEventHandler CollectionChanged;
}

