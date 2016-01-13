public class ReadOnlySiteLinkCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public bool Contains(ActiveDirectorySiteLink link) {}
	public int IndexOf(ActiveDirectorySiteLink link) {}
	public void CopyTo(ActiveDirectorySiteLink[] links, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ActiveDirectorySiteLink Item { get{} }
	public int Count { get{} }
}

