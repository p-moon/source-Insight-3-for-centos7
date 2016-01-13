public class GlobalCatalogCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public bool Contains(GlobalCatalog globalCatalog) {}
	public int IndexOf(GlobalCatalog globalCatalog) {}
	public void CopyTo(GlobalCatalog[] globalCatalogs, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public GlobalCatalog Item { get{} }
	public int Count { get{} }
}

