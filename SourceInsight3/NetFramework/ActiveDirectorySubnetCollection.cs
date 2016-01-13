public class ActiveDirectorySubnetCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public int Add(ActiveDirectorySubnet subnet) {}
	public void AddRange(ActiveDirectorySubnet[] subnets) {}
	public void AddRange(ActiveDirectorySubnetCollection subnets) {}
	public bool Contains(ActiveDirectorySubnet subnet) {}
	public void CopyTo(ActiveDirectorySubnet[] array, int index) {}
	public int IndexOf(ActiveDirectorySubnet subnet) {}
	public void Insert(int index, ActiveDirectorySubnet subnet) {}
	public void Remove(ActiveDirectorySubnet subnet) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ActiveDirectorySubnet Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

