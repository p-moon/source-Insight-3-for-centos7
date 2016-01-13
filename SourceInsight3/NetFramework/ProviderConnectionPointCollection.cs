public class ProviderConnectionPointCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ProviderConnectionPointCollection() {}
	public ProviderConnectionPointCollection(System.Collections.ICollection connectionPoints) {}

	// Methods
	public bool Contains(ProviderConnectionPoint connectionPoint) {}
	public int IndexOf(ProviderConnectionPoint connectionPoint) {}
	public void CopyTo(ProviderConnectionPoint[] array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ProviderConnectionPoint Default { get{} }
	public ProviderConnectionPoint Item { get{} }
	public ProviderConnectionPoint Item { get{} }
	public int Count { get{} }
}

