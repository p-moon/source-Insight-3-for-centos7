public class WebPartZoneCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public WebPartZoneCollection() {}
	public WebPartZoneCollection(System.Collections.ICollection webPartZones) {}

	// Methods
	public bool Contains(WebPartZoneBase value) {}
	public int IndexOf(WebPartZoneBase value) {}
	public void CopyTo(WebPartZoneBase[] array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public WebPartZoneBase Item { get{} }
	public WebPartZoneBase Item { get{} }
	public int Count { get{} }
}

