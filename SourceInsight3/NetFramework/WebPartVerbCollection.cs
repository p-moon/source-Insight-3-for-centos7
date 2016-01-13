public class WebPartVerbCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public WebPartVerbCollection() {}
	public WebPartVerbCollection(System.Collections.ICollection verbs) {}
	public WebPartVerbCollection(WebPartVerbCollection existingVerbs, System.Collections.ICollection verbs) {}

	// Methods
	public bool Contains(WebPartVerb value) {}
	public void CopyTo(WebPartVerb[] array, int index) {}
	public int IndexOf(WebPartVerb value) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public WebPartVerbCollection Empty;

	// Properties
	public WebPartVerb Item { get{} }
	public int Count { get{} }
}

