public class MethodDataCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public virtual void CopyTo(System.Array array, int index) {}
	public void CopyTo(MethodData[] methodArray, int index) {}
	public MethodDataEnumerator GetEnumerator() {}
	public virtual void Remove(string methodName) {}
	public virtual void Add(string methodName) {}
	public virtual void Add(string methodName, ManagementBaseObject inParameters, ManagementBaseObject outParameters) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
	public MethodData Item { get{} }
}

