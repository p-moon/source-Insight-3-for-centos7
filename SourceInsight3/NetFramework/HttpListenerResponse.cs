public class HttpListenerResponse : System.IDisposable
{

	// Methods
	public void CopyFrom(HttpListenerResponse templateResponse) {}
	public void AddHeader(string name, string value) {}
	public void AppendHeader(string name, string value) {}
	public void Redirect(string url) {}
	public void AppendCookie(Cookie cookie) {}
	public void SetCookie(Cookie cookie) {}
	public void Abort() {}
	public void Close(byte[] responseEntity, bool willBlock) {}
	public void Close() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Text.Encoding ContentEncoding { get{} set{} }
	public string ContentType { get{} set{} }
	public System.IO.Stream OutputStream { get{} }
	public string RedirectLocation { get{} set{} }
	public int StatusCode { get{} set{} }
	public string StatusDescription { get{} set{} }
	public CookieCollection Cookies { get{} set{} }
	public bool SendChunked { get{} set{} }
	public bool KeepAlive { get{} set{} }
	public WebHeaderCollection Headers { get{} set{} }
	public long ContentLength64 { get{} set{} }
	public System.Version ProtocolVersion { get{} set{} }
}

