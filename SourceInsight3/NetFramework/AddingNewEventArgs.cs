public class AddingNewEventArgs : System.EventArgs
{

	// Constructors
	public AddingNewEventArgs() {}
	public AddingNewEventArgs(object newObject) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object NewObject { get{} set{} }
}

