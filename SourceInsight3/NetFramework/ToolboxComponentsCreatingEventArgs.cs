public class ToolboxComponentsCreatingEventArgs : System.EventArgs
{

	// Constructors
	public ToolboxComponentsCreatingEventArgs(System.ComponentModel.Design.IDesignerHost host) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.ComponentModel.Design.IDesignerHost DesignerHost { get{} }
}

