public class HttpListener : System.IDisposable
{

	// Constructors
	public HttpListener() {}

	// Methods
	public void Start() {}
	public void Stop() {}
	public void Abort() {}
	public void Close() {}
	public HttpListenerContext GetContext() {}
	public System.IAsyncResult BeginGetContext(System.AsyncCallback callback, object state) {}
	public HttpListenerContext EndGetContext(System.IAsyncResult asyncResult) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public AuthenticationSchemeSelector AuthenticationSchemeSelectorDelegate { get{} set{} }
	public AuthenticationSchemes AuthenticationSchemes { get{} set{} }
	public string Realm { get{} set{} }
	public bool IsSupported { get{} }
	public bool IsListening { get{} }
	public bool IgnoreWriteExceptions { get{} set{} }
	public bool UnsafeConnectionNtlmAuthentication { get{} set{} }
	public HttpListenerPrefixCollection Prefixes { get{} }
}

