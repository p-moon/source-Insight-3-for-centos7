public class ActiveDirectorySiteCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public int Add(ActiveDirectorySite site) {}
	public void AddRange(ActiveDirectorySite[] sites) {}
	public void AddRange(ActiveDirectorySiteCollection sites) {}
	public bool Contains(ActiveDirectorySite site) {}
	public void CopyTo(ActiveDirectorySite[] array, int index) {}
	public int IndexOf(ActiveDirectorySite site) {}
	public void Insert(int index, ActiveDirectorySite site) {}
	public void Remove(ActiveDirectorySite site) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ActiveDirectorySite Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

