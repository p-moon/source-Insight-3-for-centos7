public class WebPartDisplayModeCancelEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public WebPartDisplayModeCancelEventArgs(WebPartDisplayMode newDisplayMode) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public WebPartDisplayMode NewDisplayMode { get{} set{} }
	public bool Cancel { get{} set{} }
}

