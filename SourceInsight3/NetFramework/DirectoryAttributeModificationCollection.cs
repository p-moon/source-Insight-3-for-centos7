public class DirectoryAttributeModificationCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public DirectoryAttributeModificationCollection() {}

	// Methods
	public int Add(DirectoryAttributeModification attribute) {}
	public void AddRange(DirectoryAttributeModification[] attributes) {}
	public void AddRange(DirectoryAttributeModificationCollection attributeCollection) {}
	public bool Contains(DirectoryAttributeModification value) {}
	public void CopyTo(DirectoryAttributeModification[] array, int index) {}
	public int IndexOf(DirectoryAttributeModification value) {}
	public void Insert(int index, DirectoryAttributeModification value) {}
	public void Remove(DirectoryAttributeModification value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DirectoryAttributeModification Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

