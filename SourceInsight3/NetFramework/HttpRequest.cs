public class HttpRequest
{

	// Constructors
	public HttpRequest(string filename, string url, string queryString) {}

	// Methods
	public byte[] BinaryRead(int count) {}
	public void ValidateInput() {}
	public int[] MapImageCoordinates(string imageFieldName) {}
	public void SaveAs(string filename, bool includeHeaders) {}
	public string MapPath(string virtualPath) {}
	public string MapPath(string virtualPath, string baseVirtualDir, bool allowCrossAppMapping) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsLocal { get{} }
	public string HttpMethod { get{} }
	public string RequestType { get{} set{} }
	public string ContentType { get{} set{} }
	public int ContentLength { get{} }
	public System.Text.Encoding ContentEncoding { get{} set{} }
	public string[] AcceptTypes { get{} }
	public bool IsAuthenticated { get{} }
	public bool IsSecureConnection { get{} }
	public string Path { get{} }
	public string AnonymousID { get{} }
	public string FilePath { get{} }
	public string CurrentExecutionFilePath { get{} }
	public string AppRelativeCurrentExecutionFilePath { get{} }
	public string PathInfo { get{} }
	public string PhysicalPath { get{} }
	public string ApplicationPath { get{} }
	public string PhysicalApplicationPath { get{} }
	public string UserAgent { get{} }
	public string[] UserLanguages { get{} }
	public HttpBrowserCapabilities Browser { get{} set{} }
	public string UserHostName { get{} }
	public string UserHostAddress { get{} }
	public string RawUrl { get{} }
	public System.Uri Url { get{} }
	public System.Uri UrlReferrer { get{} }
	public System.Collections.Specialized.NameValueCollection Params { get{} }
	public string Item { get{} }
	public System.Collections.Specialized.NameValueCollection QueryString { get{} }
	public System.Collections.Specialized.NameValueCollection Form { get{} }
	public System.Collections.Specialized.NameValueCollection Headers { get{} }
	public System.Collections.Specialized.NameValueCollection ServerVariables { get{} }
	public HttpCookieCollection Cookies { get{} }
	public HttpFileCollection Files { get{} }
	public System.IO.Stream InputStream { get{} }
	public int TotalBytes { get{} }
	public System.IO.Stream Filter { get{} set{} }
	public HttpClientCertificate ClientCertificate { get{} }
	public System.Security.Principal.WindowsIdentity LogonUserIdentity { get{} }
}

