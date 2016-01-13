public class HttpContext : System.IServiceProvider
{

	// Constructors
	public HttpContext(HttpRequest request, HttpResponse response) {}
	public HttpContext(HttpWorkerRequest wr) {}

	// Methods
	public void AddError(System.Exception errorInfo) {}
	public void ClearError() {}
	public static object GetAppConfig(string name) {}
	public object GetConfig(string name) {}
	public object GetSection(string sectionName) {}
	public void RewritePath(string path) {}
	public void RewritePath(string path, bool rebaseClientPath) {}
	public void RewritePath(string filePath, string pathInfo, string queryString) {}
	public void RewritePath(string filePath, string pathInfo, string queryString, bool setClientFilePath) {}
	public static object GetGlobalResourceObject(string classKey, string resourceKey) {}
	public static object GetGlobalResourceObject(string classKey, string resourceKey, System.Globalization.CultureInfo culture) {}
	public static object GetLocalResourceObject(string virtualPath, string resourceKey) {}
	public static object GetLocalResourceObject(string virtualPath, string resourceKey, System.Globalization.CultureInfo culture) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public HttpContext Current { get{} set{} }
	public HttpApplication ApplicationInstance { get{} set{} }
	public HttpApplicationState Application { get{} }
	public IHttpHandler Handler { get{} set{} }
	public IHttpHandler PreviousHandler { get{} }
	public IHttpHandler CurrentHandler { get{} }
	public HttpRequest Request { get{} }
	public HttpResponse Response { get{} }
	public TraceContext Trace { get{} }
	public System.Collections.IDictionary Items { get{} }
	public System.Web.SessionState.HttpSessionState Session { get{} }
	public HttpServerUtility Server { get{} }
	public System.Exception Error { get{} }
	public System.Exception[] AllErrors { get{} }
	public System.Security.Principal.IPrincipal User { get{} set{} }
	public System.Web.Profile.ProfileBase Profile { get{} }
	public bool SkipAuthorization { get{} set{} }
	public bool IsDebuggingEnabled { get{} }
	public bool IsCustomErrorEnabled { get{} }
	public System.DateTime Timestamp { get{} }
	public System.Web.Caching.Cache Cache { get{} }
	public RequestNotification CurrentNotification { get{} set{} }
	public bool IsPostNotification { get{} set{} }
}

