public class FileAuthorizationModule : System.Web.IHttpModule
{

	// Constructors
	public FileAuthorizationModule() {}

	// Methods
	public static bool CheckFileAccessForUser(string virtualPath, System.IntPtr token, string verb) {}
	public virtual void Init(System.Web.HttpApplication app) {}
	public virtual void Dispose() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

