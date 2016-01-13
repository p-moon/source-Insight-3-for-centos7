public class DirectoryServerCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public int Add(DirectoryServer server) {}
	public void AddRange(DirectoryServer[] servers) {}
	public bool Contains(DirectoryServer server) {}
	public void CopyTo(DirectoryServer[] array, int index) {}
	public int IndexOf(DirectoryServer server) {}
	public void Insert(int index, DirectoryServer server) {}
	public void Remove(DirectoryServer server) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DirectoryServer Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

