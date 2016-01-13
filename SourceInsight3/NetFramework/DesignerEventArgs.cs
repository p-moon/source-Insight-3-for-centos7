public class DesignerEventArgs : System.EventArgs
{

	// Constructors
	public DesignerEventArgs(IDesignerHost host) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public IDesignerHost Designer { get{} }
}

