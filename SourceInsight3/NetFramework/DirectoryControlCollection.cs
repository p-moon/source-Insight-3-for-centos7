public class DirectoryControlCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public DirectoryControlCollection() {}

	// Methods
	public int Add(DirectoryControl control) {}
	public void AddRange(DirectoryControl[] controls) {}
	public void AddRange(DirectoryControlCollection controlCollection) {}
	public bool Contains(DirectoryControl value) {}
	public void CopyTo(DirectoryControl[] array, int index) {}
	public int IndexOf(DirectoryControl value) {}
	public void Insert(int index, DirectoryControl value) {}
	public void Remove(DirectoryControl value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DirectoryControl Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

