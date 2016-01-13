public class PropertyValueChangedEventArgs : System.EventArgs
{

	// Constructors
	public PropertyValueChangedEventArgs(GridItem changedItem, object oldValue) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public GridItem ChangedItem { get{} }
	public object OldValue { get{} }
}

