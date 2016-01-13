public class ListSortDescription
{

	// Constructors
	public ListSortDescription(PropertyDescriptor property, ListSortDirection direction) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public PropertyDescriptor PropertyDescriptor { get{} set{} }
	public ListSortDirection SortDirection { get{} set{} }
}

