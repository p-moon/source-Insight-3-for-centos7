public class WebPartDisplayModeEventArgs : System.EventArgs
{

	// Constructors
	public WebPartDisplayModeEventArgs(WebPartDisplayMode oldDisplayMode) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public WebPartDisplayMode OldDisplayMode { get{} set{} }
}

