public class OidCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public OidCollection() {}

	// Methods
	public int Add(Oid oid) {}
	public OidEnumerator GetEnumerator() {}
	public void CopyTo(Oid[] array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Oid Item { get{} }
	public Oid Item { get{} }
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}

