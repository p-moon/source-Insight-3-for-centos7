public class DirectoryAttributeCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public DirectoryAttributeCollection() {}

	// Methods
	public int Add(DirectoryAttribute attribute) {}
	public void AddRange(DirectoryAttribute[] attributes) {}
	public void AddRange(DirectoryAttributeCollection attributeCollection) {}
	public bool Contains(DirectoryAttribute value) {}
	public void CopyTo(DirectoryAttribute[] array, int index) {}
	public int IndexOf(DirectoryAttribute value) {}
	public void Insert(int index, DirectoryAttribute value) {}
	public void Remove(DirectoryAttribute value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DirectoryAttribute Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

