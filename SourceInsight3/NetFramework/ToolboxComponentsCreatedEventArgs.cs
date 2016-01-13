public class ToolboxComponentsCreatedEventArgs : System.EventArgs
{

	// Constructors
	public ToolboxComponentsCreatedEventArgs(System.ComponentModel.IComponent[] components) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.ComponentModel.IComponent[] Components { get{} }
}

