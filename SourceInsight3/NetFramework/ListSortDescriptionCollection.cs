public class ListSortDescriptionCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ListSortDescriptionCollection() {}
	public ListSortDescriptionCollection(ListSortDescription[] sorts) {}

	// Methods
	public virtual bool Contains(object value) {}
	public virtual int IndexOf(object value) {}
	public virtual void CopyTo(System.Array array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ListSortDescription Item { get{} set{} }
	public int Count { get{} }
}

