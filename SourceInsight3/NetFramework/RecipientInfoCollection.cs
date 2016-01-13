public class RecipientInfoCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public RecipientInfoEnumerator GetEnumerator() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public void CopyTo(RecipientInfo[] array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public RecipientInfo Item { get{} }
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}

