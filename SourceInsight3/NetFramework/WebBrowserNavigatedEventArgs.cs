public class WebBrowserNavigatedEventArgs : System.EventArgs
{

	// Constructors
	public WebBrowserNavigatedEventArgs(System.Uri url) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Uri Url { get{} }
}

