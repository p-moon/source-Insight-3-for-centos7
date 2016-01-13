public class ReplicationNeighborCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public bool Contains(ReplicationNeighbor neighbor) {}
	public int IndexOf(ReplicationNeighbor neighbor) {}
	public void CopyTo(ReplicationNeighbor[] neighbors, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ReplicationNeighbor Item { get{} }
	public int Count { get{} }
}

