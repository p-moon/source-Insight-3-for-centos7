public class ManagementObjectCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.IDisposable
{

	// Methods
	public virtual void Dispose() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public void CopyTo(ManagementBaseObject[] objectCollection, int index) {}
	public ManagementObjectEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}

