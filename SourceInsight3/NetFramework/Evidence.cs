public class Evidence : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public Evidence() {}
	public Evidence(Evidence evidence) {}
	public Evidence(object[] hostEvidence, object[] assemblyEvidence) {}

	// Methods
	public void AddHost(object id) {}
	public void AddAssembly(object id) {}
	public void Merge(Evidence evidence) {}
	public virtual void CopyTo(System.Array array, int index) {}
	public System.Collections.IEnumerator GetHostEnumerator() {}
	public System.Collections.IEnumerator GetAssemblyEnumerator() {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void Clear() {}
	public void RemoveType(Type t) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool Locked { get{} set{} }
	public int Count { get{} }
	public object SyncRoot { get{} }
	public bool IsSynchronized { get{} }
	public bool IsReadOnly { get{} }
}

