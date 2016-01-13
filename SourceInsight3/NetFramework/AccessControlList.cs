public class AccessControlList : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public AccessControlList() {}

	// Methods
	public int Add(AccessControlEntry entry) {}
	public void Insert(int index, AccessControlEntry entry) {}
	public int IndexOf(AccessControlEntry entry) {}
	public bool Contains(AccessControlEntry entry) {}
	public void Remove(AccessControlEntry entry) {}
	public void CopyTo(AccessControlEntry[] array, int index) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

