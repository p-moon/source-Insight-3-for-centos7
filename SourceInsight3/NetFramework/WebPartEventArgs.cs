public class WebPartEventArgs : System.EventArgs
{

	// Constructors
	public WebPartEventArgs(WebPart webPart) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public WebPart WebPart { get{} }
}

