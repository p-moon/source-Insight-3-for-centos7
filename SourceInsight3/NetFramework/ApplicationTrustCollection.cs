public class ApplicationTrustCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public int Add(ApplicationTrust trust) {}
	public void AddRange(ApplicationTrust[] trusts) {}
	public void AddRange(ApplicationTrustCollection trusts) {}
	public ApplicationTrustCollection Find(System.ApplicationIdentity applicationIdentity, ApplicationVersionMatch versionMatch) {}
	public void Remove(System.ApplicationIdentity applicationIdentity, ApplicationVersionMatch versionMatch) {}
	public void Remove(ApplicationTrust trust) {}
	public void RemoveRange(ApplicationTrust[] trusts) {}
	public void RemoveRange(ApplicationTrustCollection trusts) {}
	public void Clear() {}
	public ApplicationTrustEnumerator GetEnumerator() {}
	public void CopyTo(ApplicationTrust[] array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public ApplicationTrust Item { get{} }
	public ApplicationTrust Item { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}

