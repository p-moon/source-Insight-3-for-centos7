public interface IHttpHandler
{

	// Methods
	public abstract virtual void ProcessRequest(HttpContext context) {}

	// Properties
	public bool IsReusable { get{} }
}

