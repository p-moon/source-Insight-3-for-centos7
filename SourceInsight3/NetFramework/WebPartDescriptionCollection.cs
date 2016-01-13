public class WebPartDescriptionCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public WebPartDescriptionCollection() {}
	public WebPartDescriptionCollection(System.Collections.ICollection webPartDescriptions) {}

	// Methods
	public bool Contains(WebPartDescription value) {}
	public int IndexOf(WebPartDescription value) {}
	public void CopyTo(WebPartDescription[] array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public WebPartDescription Item { get{} }
	public WebPartDescription Item { get{} }
	public int Count { get{} }
}

