public class HttpServerUtility
{

	// Methods
	public object CreateObject(string progID) {}
	public object CreateObject(Type type) {}
	public object CreateObjectFromClsid(string clsid) {}
	public string MapPath(string path) {}
	public System.Exception GetLastError() {}
	public void ClearError() {}
	public void Execute(string path) {}
	public void Execute(string path, System.IO.TextWriter writer) {}
	public void Execute(string path, bool preserveForm) {}
	public void Execute(string path, System.IO.TextWriter writer, bool preserveForm) {}
	public void Execute(IHttpHandler handler, System.IO.TextWriter writer, bool preserveForm) {}
	public void Transfer(string path, bool preserveForm) {}
	public void Transfer(string path) {}
	public void Transfer(IHttpHandler handler, bool preserveForm) {}
	public void TransferRequest(string path) {}
	public void TransferRequest(string path, bool preserveForm) {}
	public void TransferRequest(string path, bool preserveForm, string method, System.Collections.Specialized.NameValueCollection headers) {}
	public string HtmlDecode(string s) {}
	public void HtmlDecode(string s, System.IO.TextWriter output) {}
	public string HtmlEncode(string s) {}
	public void HtmlEncode(string s, System.IO.TextWriter output) {}
	public string UrlEncode(string s) {}
	public string UrlPathEncode(string s) {}
	public void UrlEncode(string s, System.IO.TextWriter output) {}
	public string UrlDecode(string s) {}
	public void UrlDecode(string s, System.IO.TextWriter output) {}
	public static string UrlTokenEncode(byte[] input) {}
	public static byte[] UrlTokenDecode(string input) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string MachineName { get{} }
	public int ScriptTimeout { get{} set{} }
}

