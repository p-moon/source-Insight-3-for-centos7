public class BehaviorDragDropEventArgs : System.EventArgs
{

	// Constructors
	public BehaviorDragDropEventArgs(System.Collections.ICollection dragComponents) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.ICollection DragComponents { get{} }
}

