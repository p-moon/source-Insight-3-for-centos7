public class HttpListenerRequest
{

	// Methods
	public System.Security.Cryptography.X509Certificates.X509Certificate2 GetClientCertificate() {}
	public System.IAsyncResult BeginGetClientCertificate(System.AsyncCallback requestCallback, object state) {}
	public System.Security.Cryptography.X509Certificates.X509Certificate2 EndGetClientCertificate(System.IAsyncResult asyncResult) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Guid RequestTraceIdentifier { get{} }
	public string[] AcceptTypes { get{} }
	public System.Text.Encoding ContentEncoding { get{} }
	public long ContentLength64 { get{} }
	public string ContentType { get{} }
	public System.Collections.Specialized.NameValueCollection Headers { get{} }
	public string HttpMethod { get{} }
	public System.IO.Stream InputStream { get{} }
	public bool IsAuthenticated { get{} }
	public bool IsLocal { get{} }
	public bool IsSecureConnection { get{} }
	public System.Collections.Specialized.NameValueCollection QueryString { get{} }
	public string RawUrl { get{} }
	public System.Uri Url { get{} }
	public System.Uri UrlReferrer { get{} }
	public string UserAgent { get{} }
	public string UserHostAddress { get{} }
	public string UserHostName { get{} }
	public string[] UserLanguages { get{} }
	public int ClientCertificateError { get{} }
	public CookieCollection Cookies { get{} }
	public System.Version ProtocolVersion { get{} }
	public bool HasEntityBody { get{} }
	public bool KeepAlive { get{} }
	public IPEndPoint RemoteEndPoint { get{} }
	public IPEndPoint LocalEndPoint { get{} }
}

