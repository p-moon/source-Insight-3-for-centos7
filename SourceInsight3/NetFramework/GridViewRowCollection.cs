public class GridViewRowCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public GridViewRowCollection(System.Collections.ArrayList rows) {}

	// Methods
	public void CopyTo(GridViewRow[] array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
	public GridViewRow Item { get{} }
}

