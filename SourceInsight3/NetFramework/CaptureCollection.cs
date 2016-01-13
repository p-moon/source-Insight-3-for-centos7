public class CaptureCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public virtual void CopyTo(System.Array array, int arrayIndex) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object SyncRoot { get{} }
	public bool IsSynchronized { get{} }
	public bool IsReadOnly { get{} }
	public int Count { get{} }
	public Capture Item { get{} }
}

