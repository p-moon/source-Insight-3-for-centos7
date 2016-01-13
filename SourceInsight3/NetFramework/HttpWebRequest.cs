public class HttpWebRequest : WebRequest, System.Runtime.Serialization.ISerializable
{

	// Methods
	public virtual System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state) {}
	public virtual System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult) {}
	public virtual System.IO.Stream GetRequestStream() {}
	public virtual System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state) {}
	public virtual WebResponse EndGetResponse(System.IAsyncResult asyncResult) {}
	public virtual WebResponse GetResponse() {}
	public virtual void Abort() {}
	public void AddRange(int from, int to) {}
	public void AddRange(int range) {}
	public void AddRange(string rangeSpecifier, int from, int to) {}
	public void AddRange(string rangeSpecifier, int range) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool AllowAutoRedirect { get{} set{} }
	public bool AllowWriteStreamBuffering { get{} set{} }
	public bool HaveResponse { get{} }
	public bool KeepAlive { get{} set{} }
	public bool Pipelined { get{} set{} }
	public bool PreAuthenticate { get{} set{} }
	public bool UnsafeAuthenticatedConnectionSharing { get{} set{} }
	public bool SendChunked { get{} set{} }
	public DecompressionMethods AutomaticDecompression { get{} set{} }
	public System.Net.Cache.RequestCachePolicy DefaultCachePolicy { get{} set{} }
	public int DefaultMaximumResponseHeadersLength { get{} set{} }
	public int DefaultMaximumErrorResponseLength { get{} set{} }
	public int MaximumResponseHeadersLength { get{} set{} }
	public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get{} set{} }
	public CookieContainer CookieContainer { get{} set{} }
	public System.Uri RequestUri { get{} }
	public long ContentLength { get{} set{} }
	public int Timeout { get{} set{} }
	public int ReadWriteTimeout { get{} set{} }
	public System.Uri Address { get{} }
	public HttpContinueDelegate ContinueDelegate { get{} set{} }
	public ServicePoint ServicePoint { get{} }
	public int MaximumAutomaticRedirections { get{} set{} }
	public string Method { get{} set{} }
	public ICredentials Credentials { get{} set{} }
	public bool UseDefaultCredentials { get{} set{} }
	public string ConnectionGroupName { get{} set{} }
	public WebHeaderCollection Headers { get{} set{} }
	public IWebProxy Proxy { get{} set{} }
	public System.Version ProtocolVersion { get{} set{} }
	public string ContentType { get{} set{} }
	public string MediaType { get{} set{} }
	public string TransferEncoding { get{} set{} }
	public string Connection { get{} set{} }
	public string Accept { get{} set{} }
	public string Referer { get{} set{} }
	public string UserAgent { get{} set{} }
	public string Expect { get{} set{} }
	public System.DateTime IfModifiedSince { get{} set{} }
	public System.Net.Cache.RequestCachePolicy CachePolicy { get{} set{} }
	public System.Net.Security.AuthenticationLevel AuthenticationLevel { get{} set{} }
	public System.Security.Principal.TokenImpersonationLevel ImpersonationLevel { get{} set{} }
}

