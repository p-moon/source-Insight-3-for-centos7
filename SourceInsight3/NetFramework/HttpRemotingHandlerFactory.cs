public class HttpRemotingHandlerFactory : System.Web.IHttpHandlerFactory
{

	// Constructors
	public HttpRemotingHandlerFactory() {}

	// Methods
	public virtual System.Web.IHttpHandler GetHandler(System.Web.HttpContext context, string verb, string url, string filePath) {}
	public virtual void ReleaseHandler(System.Web.IHttpHandler handler) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

