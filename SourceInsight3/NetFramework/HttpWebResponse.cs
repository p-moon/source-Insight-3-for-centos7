public class HttpWebResponse : WebResponse, System.Runtime.Serialization.ISerializable, System.IDisposable
{

	// Methods
	public virtual System.IO.Stream GetResponseStream() {}
	public virtual void Close() {}
	public string GetResponseHeader(string headerName) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsMutuallyAuthenticated { get{} }
	public CookieCollection Cookies { get{} set{} }
	public WebHeaderCollection Headers { get{} }
	public long ContentLength { get{} }
	public string ContentEncoding { get{} }
	public string ContentType { get{} }
	public string CharacterSet { get{} }
	public string Server { get{} }
	public System.DateTime LastModified { get{} }
	public HttpStatusCode StatusCode { get{} }
	public string StatusDescription { get{} }
	public System.Version ProtocolVersion { get{} }
	public System.Uri ResponseUri { get{} }
	public string Method { get{} }
	public bool IsFromCache { get{} }
}

