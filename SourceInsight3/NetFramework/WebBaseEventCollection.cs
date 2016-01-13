public class WebBaseEventCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public WebBaseEventCollection(System.Collections.ICollection events) {}

	// Methods
	public int IndexOf(WebBaseEvent value) {}
	public bool Contains(WebBaseEvent value) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public WebBaseEvent Item { get{} }
	public int Count { get{} }
}

