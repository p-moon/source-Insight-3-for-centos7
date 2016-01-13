public class SortOption
{

	// Constructors
	public SortOption() {}
	public SortOption(string propertyName, SortDirection direction) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string PropertyName { get{} set{} }
	public SortDirection Direction { get{} set{} }
}

