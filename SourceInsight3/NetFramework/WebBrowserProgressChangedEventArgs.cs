public class WebBrowserProgressChangedEventArgs : System.EventArgs
{

	// Constructors
	public WebBrowserProgressChangedEventArgs(long currentProgress, long maximumProgress) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public long CurrentProgress { get{} }
	public long MaximumProgress { get{} }
}

