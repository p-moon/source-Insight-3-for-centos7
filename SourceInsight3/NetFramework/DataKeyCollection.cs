public class DataKeyCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public DataKeyCollection(System.Collections.ArrayList keys) {}

	// Methods
	public virtual void CopyTo(System.Array array, int index) {}
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
	public object Item { get{} }
}

