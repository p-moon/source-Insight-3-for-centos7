public class AdamRoleCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public bool Contains(AdamRole role) {}
	public int IndexOf(AdamRole role) {}
	public void CopyTo(AdamRole[] roles, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public AdamRole Item { get{} }
	public int Count { get{} }
}

