public class ReadOnlyDirectoryServerCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public bool Contains(DirectoryServer directoryServer) {}
	public int IndexOf(DirectoryServer directoryServer) {}
	public void CopyTo(DirectoryServer[] directoryServers, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DirectoryServer Item { get{} }
	public int Count { get{} }
}

