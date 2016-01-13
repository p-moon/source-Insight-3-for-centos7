public class DetailsViewRowCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public DetailsViewRowCollection(System.Collections.ArrayList rows) {}

	// Methods
	public void CopyTo(DetailsViewRow[] array, int index) {}
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
	public DetailsViewRow Item { get{} }
}

