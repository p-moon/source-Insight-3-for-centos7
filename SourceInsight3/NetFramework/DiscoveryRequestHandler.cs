public class DiscoveryRequestHandler : System.Web.IHttpHandler
{

	// Constructors
	public DiscoveryRequestHandler() {}

	// Methods
	public virtual void ProcessRequest(System.Web.HttpContext context) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsReusable { get{} }
}

