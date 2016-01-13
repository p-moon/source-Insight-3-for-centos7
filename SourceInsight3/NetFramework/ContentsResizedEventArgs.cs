public class ContentsResizedEventArgs : System.EventArgs
{

	// Constructors
	public ContentsResizedEventArgs(System.Drawing.Rectangle newRectangle) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Rectangle NewRectangle { get{} }
}

