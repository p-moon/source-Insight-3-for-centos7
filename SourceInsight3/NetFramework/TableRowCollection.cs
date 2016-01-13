public class TableRowCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public int Add(TableRow row) {}
	public void AddAt(int index, TableRow row) {}
	public void AddRange(TableRow[] rows) {}
	public virtual void Clear() {}
	public int GetRowIndex(TableRow row) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public void Remove(TableRow row) {}
	public virtual void RemoveAt(int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public TableRow Item { get{} }
	public object SyncRoot { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
}

