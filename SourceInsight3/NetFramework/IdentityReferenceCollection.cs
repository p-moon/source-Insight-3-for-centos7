public class IdentityReferenceCollection : ICollection<System.Security.Principal.IdentityReference>, IEnumerable<System.Security.Principal.IdentityReference>, System.Collections.IEnumerable
{

	// Constructors
	public IdentityReferenceCollection() {}
	public IdentityReferenceCollection(int capacity) {}

	// Methods
	public virtual void CopyTo(IdentityReference[] array, int offset) {}
	public virtual void Add(IdentityReference identity) {}
	public virtual bool Remove(IdentityReference identity) {}
	public virtual void Clear() {}
	public virtual bool Contains(IdentityReference identity) {}
	public virtual IEnumerator<System.Security.Principal.IdentityReference> GetEnumerator() {}
	public IdentityReferenceCollection Translate(Type targetType) {}
	public IdentityReferenceCollection Translate(Type targetType, bool forceSuccess) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public IdentityReference Item { get{} set{} }
}

