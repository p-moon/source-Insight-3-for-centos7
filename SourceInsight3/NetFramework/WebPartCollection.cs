public class WebPartCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public WebPartCollection() {}
	public WebPartCollection(System.Collections.ICollection webParts) {}

	// Methods
	public bool Contains(WebPart value) {}
	public int IndexOf(WebPart value) {}
	public void CopyTo(WebPart[] array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public WebPart Item { get{} }
	public WebPart Item { get{} }
	public int Count { get{} }
}

