public class SignerInfoCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public SignerInfoEnumerator GetEnumerator() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public void CopyTo(SignerInfo[] array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SignerInfo Item { get{} }
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}

