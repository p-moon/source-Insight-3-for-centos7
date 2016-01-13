public class WebRequest : System.MarshalByRefObject, System.Runtime.Serialization.ISerializable
{

	// Methods
	public static WebRequest Create(string requestUriString) {}
	public static WebRequest Create(System.Uri requestUri) {}
	public static WebRequest CreateDefault(System.Uri requestUri) {}
	public static bool RegisterPrefix(string prefix, IWebRequestCreate creator) {}
	public virtual System.IO.Stream GetRequestStream() {}
	public virtual WebResponse GetResponse() {}
	public virtual System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state) {}
	public virtual WebResponse EndGetResponse(System.IAsyncResult asyncResult) {}
	public virtual System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state) {}
	public virtual System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult) {}
	public virtual void Abort() {}
	public static IWebProxy GetSystemWebProxy() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Net.Cache.RequestCachePolicy DefaultCachePolicy { get{} set{} }
	public System.Net.Cache.RequestCachePolicy CachePolicy { get{} set{} }
	public string Method { get{} set{} }
	public System.Uri RequestUri { get{} }
	public string ConnectionGroupName { get{} set{} }
	public WebHeaderCollection Headers { get{} set{} }
	public long ContentLength { get{} set{} }
	public string ContentType { get{} set{} }
	public ICredentials Credentials { get{} set{} }
	public bool UseDefaultCredentials { get{} set{} }
	public IWebProxy Proxy { get{} set{} }
	public bool PreAuthenticate { get{} set{} }
	public int Timeout { get{} set{} }
	public System.Net.Security.AuthenticationLevel AuthenticationLevel { get{} set{} }
	public System.Security.Principal.TokenImpersonationLevel ImpersonationLevel { get{} set{} }
	public IWebProxy DefaultWebProxy { get{} set{} }
}

