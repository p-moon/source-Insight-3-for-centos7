public class WebPartCancelEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public WebPartCancelEventArgs(WebPart webPart) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public WebPart WebPart { get{} set{} }
	public bool Cancel { get{} set{} }
}

