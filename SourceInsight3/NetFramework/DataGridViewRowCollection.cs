public class DataGridViewRowCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public DataGridViewRowCollection(DataGridView dataGridView) {}

	// Methods
	public DataGridViewRow SharedRow(int rowIndex) {}
	public virtual int Add() {}
	public virtual int Add(object[] values) {}
	public virtual int Add(DataGridViewRow dataGridViewRow) {}
	public virtual int Add(int count) {}
	public virtual int AddCopy(int indexSource) {}
	public virtual int AddCopies(int indexSource, int count) {}
	public virtual void AddRange(DataGridViewRow[] dataGridViewRows) {}
	public virtual void Clear() {}
	public virtual bool Contains(DataGridViewRow dataGridViewRow) {}
	public void CopyTo(DataGridViewRow[] array, int index) {}
	public int GetFirstRow(DataGridViewElementStates includeFilter) {}
	public int GetFirstRow(DataGridViewElementStates includeFilter, DataGridViewElementStates excludeFilter) {}
	public int GetLastRow(DataGridViewElementStates includeFilter) {}
	public int GetNextRow(int indexStart, DataGridViewElementStates includeFilter) {}
	public int GetNextRow(int indexStart, DataGridViewElementStates includeFilter, DataGridViewElementStates excludeFilter) {}
	public int GetPreviousRow(int indexStart, DataGridViewElementStates includeFilter) {}
	public int GetPreviousRow(int indexStart, DataGridViewElementStates includeFilter, DataGridViewElementStates excludeFilter) {}
	public int GetRowCount(DataGridViewElementStates includeFilter) {}
	public int GetRowsHeight(DataGridViewElementStates includeFilter) {}
	public virtual DataGridViewElementStates GetRowState(int rowIndex) {}
	public int IndexOf(DataGridViewRow dataGridViewRow) {}
	public virtual void Insert(int rowIndex, object[] values) {}
	public virtual void Insert(int rowIndex, DataGridViewRow dataGridViewRow) {}
	public virtual void Insert(int rowIndex, int count) {}
	public virtual void InsertCopy(int indexSource, int indexDestination) {}
	public virtual void InsertCopies(int indexSource, int indexDestination, int count) {}
	public virtual void InsertRange(int rowIndex, DataGridViewRow[] dataGridViewRows) {}
	public virtual void Remove(DataGridViewRow dataGridViewRow) {}
	public virtual void RemoveAt(int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public DataGridViewRow Item { get{} }

	// Events
	public event System.ComponentModel.CollectionChangeEventHandler CollectionChanged;
}

