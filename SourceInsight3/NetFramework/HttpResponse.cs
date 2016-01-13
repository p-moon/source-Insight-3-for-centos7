public class HttpResponse
{

	// Constructors
	public HttpResponse(System.IO.TextWriter writer) {}

	// Methods
	public void DisableKernelCache() {}
	public void AddFileDependency(string filename) {}
	public void AddFileDependencies(System.Collections.ArrayList filenames) {}
	public void AddFileDependencies(string[] filenames) {}
	public void AddCacheItemDependency(string cacheKey) {}
	public void AddCacheItemDependencies(System.Collections.ArrayList cacheKeys) {}
	public void AddCacheItemDependencies(string[] cacheKeys) {}
	public void AddCacheDependency(System.Web.Caching.CacheDependency[] dependencies) {}
	public static void RemoveOutputCacheItem(string path) {}
	public void Close() {}
	public void BinaryWrite(byte[] buffer) {}
	public void Pics(string value) {}
	public void AppendHeader(string name, string value) {}
	public void AppendCookie(HttpCookie cookie) {}
	public void SetCookie(HttpCookie cookie) {}
	public void ClearHeaders() {}
	public void ClearContent() {}
	public void Clear() {}
	public void Flush() {}
	public void AppendToLog(string param) {}
	public void Redirect(string url) {}
	public void Redirect(string url, bool endResponse) {}
	public void Write(string s) {}
	public void Write(object obj) {}
	public void Write(char ch) {}
	public void Write(char[] buffer, int index, int count) {}
	public void WriteSubstitution(HttpResponseSubstitutionCallback callback) {}
	public void WriteFile(string filename) {}
	public void WriteFile(string filename, bool readIntoMemory) {}
	public void TransmitFile(string filename) {}
	public void TransmitFile(string filename, long offset, long length) {}
	public void WriteFile(string filename, long offset, long size) {}
	public void WriteFile(System.IntPtr fileHandle, long offset, long size) {}
	public void AddHeader(string name, string value) {}
	public void End() {}
	public string ApplyAppPathModifier(string virtualPath) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public HttpCookieCollection Cookies { get{} }
	public System.Collections.Specialized.NameValueCollection Headers { get{} }
	public int StatusCode { get{} set{} }
	public int SubStatusCode { get{} set{} }
	public string StatusDescription { get{} set{} }
	public bool TrySkipIisCustomErrors { get{} set{} }
	public bool BufferOutput { get{} set{} }
	public string ContentType { get{} set{} }
	public string Charset { get{} set{} }
	public System.Text.Encoding ContentEncoding { get{} set{} }
	public System.Text.Encoding HeaderEncoding { get{} set{} }
	public HttpCachePolicy Cache { get{} }
	public bool IsClientConnected { get{} }
	public bool IsRequestBeingRedirected { get{} }
	public string RedirectLocation { get{} set{} }
	public System.IO.TextWriter Output { get{} }
	public System.IO.Stream OutputStream { get{} }
	public System.IO.Stream Filter { get{} set{} }
	public bool SuppressContent { get{} set{} }
	public string Status { get{} set{} }
	public bool Buffer { get{} set{} }
	public int Expires { get{} set{} }
	public System.DateTime ExpiresAbsolute { get{} set{} }
	public string CacheControl { get{} set{} }
}

