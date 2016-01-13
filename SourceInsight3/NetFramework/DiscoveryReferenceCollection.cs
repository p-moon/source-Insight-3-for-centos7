public class DiscoveryReferenceCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public DiscoveryReferenceCollection() {}

	// Methods
	public int Add(DiscoveryReference value) {}
	public bool Contains(DiscoveryReference value) {}
	public void Remove(DiscoveryReference value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DiscoveryReference Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

