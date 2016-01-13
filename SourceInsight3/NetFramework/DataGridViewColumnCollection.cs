public class DataGridViewColumnCollection : BaseCollection, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
{

	// Constructors
	public DataGridViewColumnCollection(DataGridView dataGridView) {}

	// Methods
	public virtual int Add(string columnName, string headerText) {}
	public virtual int Add(DataGridViewColumn dataGridViewColumn) {}
	public virtual void AddRange(DataGridViewColumn[] dataGridViewColumns) {}
	public virtual void Clear() {}
	public virtual bool Contains(DataGridViewColumn dataGridViewColumn) {}
	public virtual bool Contains(string columnName) {}
	public void CopyTo(DataGridViewColumn[] array, int index) {}
	public int GetColumnCount(DataGridViewElementStates includeFilter) {}
	public int GetColumnsWidth(DataGridViewElementStates includeFilter) {}
	public DataGridViewColumn GetFirstColumn(DataGridViewElementStates includeFilter) {}
	public DataGridViewColumn GetFirstColumn(DataGridViewElementStates includeFilter, DataGridViewElementStates excludeFilter) {}
	public DataGridViewColumn GetLastColumn(DataGridViewElementStates includeFilter, DataGridViewElementStates excludeFilter) {}
	public DataGridViewColumn GetNextColumn(DataGridViewColumn dataGridViewColumnStart, DataGridViewElementStates includeFilter, DataGridViewElementStates excludeFilter) {}
	public DataGridViewColumn GetPreviousColumn(DataGridViewColumn dataGridViewColumnStart, DataGridViewElementStates includeFilter, DataGridViewElementStates excludeFilter) {}
	public int IndexOf(DataGridViewColumn dataGridViewColumn) {}
	public virtual void Insert(int columnIndex, DataGridViewColumn dataGridViewColumn) {}
	public virtual void Remove(DataGridViewColumn dataGridViewColumn) {}
	public virtual void Remove(string columnName) {}
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
	public DataGridViewColumn Item { get{} }
	public DataGridViewColumn Item { get{} }
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }

	// Events
	public event System.ComponentModel.CollectionChangeEventHandler CollectionChanged;
}

