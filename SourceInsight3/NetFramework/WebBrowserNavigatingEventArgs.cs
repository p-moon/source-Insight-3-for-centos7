public class WebBrowserNavigatingEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public WebBrowserNavigatingEventArgs(System.Uri url, string targetFrameName) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Uri Url { get{} }
	public string TargetFrameName { get{} }
	public bool Cancel { get{} set{} }
}

