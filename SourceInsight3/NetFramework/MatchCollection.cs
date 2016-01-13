public class MatchCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public virtual void CopyTo(System.Array array, int arrayIndex) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public object SyncRoot { get{} }
	public bool IsSynchronized { get{} }
	public bool IsReadOnly { get{} }
	public Match Item { get{} }
}

