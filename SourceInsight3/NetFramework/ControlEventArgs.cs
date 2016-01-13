public class ControlEventArgs : System.EventArgs
{

	// Constructors
	public ControlEventArgs(Control control) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Control Control { get{} }
}

