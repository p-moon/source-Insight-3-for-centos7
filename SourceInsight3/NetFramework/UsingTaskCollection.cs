public class UsingTaskCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public void CopyTo(UsingTask[] array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}

