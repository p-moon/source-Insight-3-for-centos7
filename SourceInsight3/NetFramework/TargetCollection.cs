public class TargetCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Target AddNewTarget(string targetName) {}
	public void RemoveTarget(Target targetToRemove) {}
	public bool Exists(string targetName) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
	public Target Item { get{} }
}

