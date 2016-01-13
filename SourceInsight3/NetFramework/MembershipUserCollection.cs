public class MembershipUserCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public MembershipUserCollection() {}

	// Methods
	public void Add(MembershipUser user) {}
	public void Remove(string name) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void SetReadOnly() {}
	public void Clear() {}
	public void CopyTo(MembershipUser[] array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MembershipUser Item { get{} }
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}

