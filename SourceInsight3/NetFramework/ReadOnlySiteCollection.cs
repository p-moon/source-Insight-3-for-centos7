public class ReadOnlySiteCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public bool Contains(ActiveDirectorySite site) {}
	public int IndexOf(ActiveDirectorySite site) {}
	public void CopyTo(ActiveDirectorySite[] sites, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ActiveDirectorySite Item { get{} }
	public int Count { get{} }
}

