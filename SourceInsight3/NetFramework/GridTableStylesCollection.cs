public class GridTableStylesCollection : BaseCollection, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
{

	// Methods
	public virtual int Add(DataGridTableStyle table) {}
	public virtual void AddRange(DataGridTableStyle[] tables) {}
	public void Clear() {}
	public bool Contains(DataGridTableStyle table) {}
	public bool Contains(string name) {}
	public void Remove(DataGridTableStyle table) {}
	public void RemoveAt(int index) {}
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
	public DataGridTableStyle Item { get{} }
	public DataGridTableStyle Item { get{} }
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }

	// Events
	public event System.ComponentModel.CollectionChangeEventHandler CollectionChanged;
}

