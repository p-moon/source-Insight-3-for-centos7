public class UriBuilder
{

	// Constructors
	public UriBuilder() {}
	public UriBuilder(string uri) {}
	public UriBuilder(Uri uri) {}
	public UriBuilder(string schemeName, string hostName) {}
	public UriBuilder(string scheme, string host, int portNumber) {}
	public UriBuilder(string scheme, string host, int port, string pathValue) {}
	public UriBuilder(string scheme, string host, int port, string path, string extraValue) {}

	// Methods
	public virtual bool Equals(object rparam) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public string Fragment { get{} set{} }
	public string Host { get{} set{} }
	public string Password { get{} set{} }
	public string Path { get{} set{} }
	public int Port { get{} set{} }
	public string Query { get{} set{} }
	public string Scheme { get{} set{} }
	public Uri Uri { get{} }
	public string UserName { get{} set{} }
}

