public class ToolBarButtonClickEventArgs : System.EventArgs
{

	// Constructors
	public ToolBarButtonClickEventArgs(ToolBarButton button) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ToolBarButton Button { get{} set{} }
}

