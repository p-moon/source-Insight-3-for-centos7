public class ReplicationOperationCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public bool Contains(ReplicationOperation operation) {}
	public int IndexOf(ReplicationOperation operation) {}
	public void CopyTo(ReplicationOperation[] operations, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ReplicationOperation Item { get{} }
	public int Count { get{} }
}

