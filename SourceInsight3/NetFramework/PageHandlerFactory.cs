public class PageHandlerFactory : System.Web.IHttpHandlerFactory2, System.Web.IHttpHandlerFactory
{

	// Methods
	public virtual System.Web.IHttpHandler GetHandler(System.Web.HttpContext context, string requestType, string virtualPath, string path) {}
	public virtual void ReleaseHandler(System.Web.IHttpHandler handler) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

