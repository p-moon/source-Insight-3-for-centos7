public class RoleGroupCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public RoleGroupCollection() {}

	// Methods
	public void Add(RoleGroup group) {}
	public void CopyTo(RoleGroup[] array, int index) {}
	public bool Contains(RoleGroup group) {}
	public RoleGroup GetMatchingRoleGroup(System.Security.Principal.IPrincipal user) {}
	public int IndexOf(RoleGroup group) {}
	public void Insert(int index, RoleGroup group) {}
	public void Remove(RoleGroup group) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public RoleGroup Item { get{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

