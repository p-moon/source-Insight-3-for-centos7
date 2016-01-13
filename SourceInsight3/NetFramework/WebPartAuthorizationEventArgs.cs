public class WebPartAuthorizationEventArgs : System.EventArgs
{

	// Constructors
	public WebPartAuthorizationEventArgs(Type type, string path, string authorizationFilter, bool isShared) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string AuthorizationFilter { get{} }
	public bool IsAuthorized { get{} set{} }
	public bool IsShared { get{} }
	public string Path { get{} }
	public Type Type { get{} }
}

