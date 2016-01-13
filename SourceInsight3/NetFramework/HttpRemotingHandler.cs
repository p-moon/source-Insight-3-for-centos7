public class HttpRemotingHandler : System.Web.IHttpHandler
{

	// Constructors
	public HttpRemotingHandler() {}
	public HttpRemotingHandler(Type type, object srvID) {}

	// Methods
	public virtual void ProcessRequest(System.Web.HttpContext context) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsReusable { get{} }
}

