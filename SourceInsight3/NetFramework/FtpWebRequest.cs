public class FtpWebRequest : WebRequest, System.Runtime.Serialization.ISerializable
{

	// Methods
	public virtual WebResponse GetResponse() {}
	public virtual System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state) {}
	public virtual WebResponse EndGetResponse(System.IAsyncResult asyncResult) {}
	public virtual System.IO.Stream GetRequestStream() {}
	public virtual System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state) {}
	public virtual System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult) {}
	public virtual void Abort() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Net.Cache.RequestCachePolicy DefaultCachePolicy { get{} set{} }
	public string Method { get{} set{} }
	public string RenameTo { get{} set{} }
	public ICredentials Credentials { get{} set{} }
	public System.Uri RequestUri { get{} }
	public int Timeout { get{} set{} }
	public int ReadWriteTimeout { get{} set{} }
	public long ContentOffset { get{} set{} }
	public long ContentLength { get{} set{} }
	public IWebProxy Proxy { get{} set{} }
	public string ConnectionGroupName { get{} set{} }
	public ServicePoint ServicePoint { get{} }
	public bool KeepAlive { get{} set{} }
	public bool UseBinary { get{} set{} }
	public bool UsePassive { get{} set{} }
	public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get{} set{} }
	public bool EnableSsl { get{} set{} }
	public WebHeaderCollection Headers { get{} set{} }
	public string ContentType { get{} set{} }
	public bool UseDefaultCredentials { get{} set{} }
	public bool PreAuthenticate { get{} set{} }
	public System.Net.Cache.RequestCachePolicy CachePolicy { get{} set{} }
	public System.Net.Security.AuthenticationLevel AuthenticationLevel { get{} set{} }
	public System.Security.Principal.TokenImpersonationLevel ImpersonationLevel { get{} set{} }
}

