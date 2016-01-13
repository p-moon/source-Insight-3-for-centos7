public class HttpListenerContext
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public HttpListenerRequest Request { get{} }
	public HttpListenerResponse Response { get{} }
	public System.Security.Principal.IPrincipal User { get{} }
}

