public class SelectionRange
{

	// Constructors
	public SelectionRange() {}
	public SelectionRange(System.DateTime lower, System.DateTime upper) {}
	public SelectionRange(SelectionRange range) {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.DateTime End { get{} set{} }
	public System.DateTime Start { get{} set{} }
}

