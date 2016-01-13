public class SecurityCallers : System.Collections.IEnumerable
{

	// Methods
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public SecurityIdentity Item { get{} }
}

