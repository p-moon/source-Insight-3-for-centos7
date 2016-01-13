public class ReplicationConnectionCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public bool Contains(ReplicationConnection connection) {}
	public int IndexOf(ReplicationConnection connection) {}
	public void CopyTo(ReplicationConnection[] connections, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ReplicationConnection Item { get{} }
	public int Count { get{} }
}

