public class InvalidateEventArgs : System.EventArgs
{

	// Constructors
	public InvalidateEventArgs(System.Drawing.Rectangle invalidRect) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Rectangle InvalidRect { get{} }
}

