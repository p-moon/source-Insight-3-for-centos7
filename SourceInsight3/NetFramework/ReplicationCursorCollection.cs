public class ReplicationCursorCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public bool Contains(ReplicationCursor cursor) {}
	public int IndexOf(ReplicationCursor cursor) {}
	public void CopyTo(ReplicationCursor[] values, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ReplicationCursor Item { get{} }
	public int Count { get{} }
}

