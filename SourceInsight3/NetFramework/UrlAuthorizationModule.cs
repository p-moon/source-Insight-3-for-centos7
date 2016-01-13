public class UrlAuthorizationModule : System.Web.IHttpModule
{

	// Constructors
	public UrlAuthorizationModule() {}

	// Methods
	public virtual void Init(System.Web.HttpApplication app) {}
	public virtual void Dispose() {}
	public static bool CheckUrlAccessForPrincipal(string virtualPath, System.Security.Principal.IPrincipal user, string verb) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

