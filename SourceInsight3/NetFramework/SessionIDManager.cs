public class SessionIDManager : ISessionIDManager
{

	// Constructors
	public SessionIDManager() {}

	// Methods
	public virtual void Initialize() {}
	public virtual bool Validate(string id) {}
	public virtual string Encode(string id) {}
	public virtual string Decode(string id) {}
	public virtual bool InitializeRequest(System.Web.HttpContext context, bool suppressAutoDetectRedirectout , System.Boolean& supportSessionIDReissue) {}
	public virtual string GetSessionID(System.Web.HttpContext context) {}
	public virtual string CreateSessionID(System.Web.HttpContext context) {}
	public virtual void SaveSessionID(System.Web.HttpContext context, string idout , System.Boolean& redirectedout , System.Boolean& cookieAdded) {}
	public virtual void RemoveSessionID(System.Web.HttpContext context) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int SessionIDMaxLength { get{} }
}

