public class ApplicationPartitionCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public bool Contains(ApplicationPartition applicationPartition) {}
	public int IndexOf(ApplicationPartition applicationPartition) {}
	public void CopyTo(ApplicationPartition[] applicationPartitions, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ApplicationPartition Item { get{} }
	public int Count { get{} }
}

