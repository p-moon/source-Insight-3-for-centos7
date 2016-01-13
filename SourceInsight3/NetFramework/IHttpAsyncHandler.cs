public interface IHttpAsyncHandler : IHttpHandler
{

	// Methods
	public abstract virtual System.IAsyncResult BeginProcessRequest(HttpContext context, System.AsyncCallback cb, object extraData) {}
	public abstract virtual void EndProcessRequest(System.IAsyncResult result) {}
}

