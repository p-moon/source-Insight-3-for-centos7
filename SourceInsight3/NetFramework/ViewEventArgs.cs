public class ViewEventArgs : System.EventArgs
{

	// Constructors
	public ViewEventArgs(ViewEvent eventType, DesignerRegion region, System.EventArgs eventArgs) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.EventArgs EventArgs { get{} }
	public ViewEvent EventType { get{} }
	public DesignerRegion Region { get{} }
}

