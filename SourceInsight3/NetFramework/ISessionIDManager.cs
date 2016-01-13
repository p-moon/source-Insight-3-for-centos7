public interface ISessionIDManager
{

	// Methods
	public abstract virtual bool InitializeRequest(System.Web.HttpContext context, bool suppressAutoDetectRedirectout , System.Boolean& supportSessionIDReissue) {}
	public abstract virtual string GetSessionID(System.Web.HttpContext context) {}
	public abstract virtual string CreateSessionID(System.Web.HttpContext context) {}
	public abstract virtual void SaveSessionID(System.Web.HttpContext context, string idout , System.Boolean& redirectedout , System.Boolean& cookieAdded) {}
	public abstract virtual void RemoveSessionID(System.Web.HttpContext context) {}
	public abstract virtual bool Validate(string id) {}
	public abstract virtual void Initialize() {}
}

