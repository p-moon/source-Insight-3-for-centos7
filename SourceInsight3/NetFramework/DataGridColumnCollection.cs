public class DataGridColumnCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Web.UI.IStateManager
{

	// Constructors
	public DataGridColumnCollection(DataGrid owner, System.Collections.ArrayList columns) {}

	// Methods
	public void Add(DataGridColumn column) {}
	public void AddAt(int index, DataGridColumn column) {}
	public void Clear() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public int IndexOf(DataGridColumn column) {}
	public void RemoveAt(int index) {}
	public void Remove(DataGridColumn column) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
	public DataGridColumn Item { get{} }
}

