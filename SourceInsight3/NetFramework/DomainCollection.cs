public class DomainCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public bool Contains(Domain domain) {}
	public int IndexOf(Domain domain) {}
	public void CopyTo(Domain[] domains, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Domain Item { get{} }
	public int Count { get{} }
}

