public interface IHttpHandlerFactory
{

	// Methods
	public abstract virtual IHttpHandler GetHandler(HttpContext context, string requestType, string url, string pathTranslated) {}
	public abstract virtual void ReleaseHandler(IHttpHandler handler) {}
}

