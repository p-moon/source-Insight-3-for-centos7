public class DefaultHttpHandler : IHttpAsyncHandler, IHttpHandler
{

	// Constructors
	public DefaultHttpHandler() {}

	// Methods
	public virtual void OnExecuteUrlPreconditionFailure() {}
	public virtual string OverrideExecuteUrlPath() {}
	public virtual System.IAsyncResult BeginProcessRequest(HttpContext context, System.AsyncCallback callback, object state) {}
	public virtual void EndProcessRequest(System.IAsyncResult result) {}
	public virtual void ProcessRequest(HttpContext context) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsReusable { get{} }
}

