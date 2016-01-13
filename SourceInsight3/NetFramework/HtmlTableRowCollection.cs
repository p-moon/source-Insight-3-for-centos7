public class HtmlTableRowCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public void Add(HtmlTableRow row) {}
	public void Insert(int index, HtmlTableRow row) {}
	public void Clear() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void Remove(HtmlTableRow row) {}
	public void RemoveAt(int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public HtmlTableRow Item { get{} }
	public object SyncRoot { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
}

