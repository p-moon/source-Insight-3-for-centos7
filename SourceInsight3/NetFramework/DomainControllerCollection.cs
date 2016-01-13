public class DomainControllerCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public bool Contains(DomainController domainController) {}
	public int IndexOf(DomainController domainController) {}
	public void CopyTo(DomainController[] domainControllers, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DomainController Item { get{} }
	public int Count { get{} }
}

