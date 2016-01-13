public class FtpWebResponse : WebResponse, System.Runtime.Serialization.ISerializable, System.IDisposable
{

	// Methods
	public virtual System.IO.Stream GetResponseStream() {}
	public virtual void Close() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public long ContentLength { get{} }
	public WebHeaderCollection Headers { get{} }
	public System.Uri ResponseUri { get{} }
	public FtpStatusCode StatusCode { get{} }
	public string StatusDescription { get{} }
	public System.DateTime LastModified { get{} }
	public string BannerMessage { get{} }
	public string WelcomeMessage { get{} }
	public string ExitMessage { get{} }
	public bool IsFromCache { get{} }
	public bool IsMutuallyAuthenticated { get{} }
	public string ContentType { get{} set{} }
}

