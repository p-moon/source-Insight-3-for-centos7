public class ComponentEventArgs : System.EventArgs
{

	// Constructors
	public ComponentEventArgs(System.ComponentModel.IComponent component) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.ComponentModel.IComponent Component { get{} }
}

