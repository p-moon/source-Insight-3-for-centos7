public class ReplicationFailureCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public bool Contains(ReplicationFailure failure) {}
	public int IndexOf(ReplicationFailure failure) {}
	public void CopyTo(ReplicationFailure[] failures, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ReplicationFailure Item { get{} }
	public int Count { get{} }
}

