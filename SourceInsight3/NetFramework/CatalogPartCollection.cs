public class CatalogPartCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public CatalogPartCollection() {}
	public CatalogPartCollection(System.Collections.ICollection catalogParts) {}
	public CatalogPartCollection(CatalogPartCollection existingCatalogParts, System.Collections.ICollection catalogParts) {}

	// Methods
	public bool Contains(CatalogPart catalogPart) {}
	public void CopyTo(CatalogPart[] array, int index) {}
	public int IndexOf(CatalogPart catalogPart) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public CatalogPartCollection Empty;

	// Properties
	public CatalogPart Item { get{} }
	public CatalogPart Item { get{} }
	public int Count { get{} }
}

