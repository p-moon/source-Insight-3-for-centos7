public class HtmlTableCellCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public void Add(HtmlTableCell cell) {}
	public void Insert(int index, HtmlTableCell cell) {}
	public void Clear() {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public void Remove(HtmlTableCell cell) {}
	public void RemoveAt(int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public HtmlTableCell Item { get{} }
	public object SyncRoot { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
}

