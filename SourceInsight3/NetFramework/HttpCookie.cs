public class HttpCookie
{

	// Constructors
	public HttpCookie(string name) {}
	public HttpCookie(string name, string value) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} set{} }
	public string Path { get{} set{} }
	public bool Secure { get{} set{} }
	public bool HttpOnly { get{} set{} }
	public string Domain { get{} set{} }
	public System.DateTime Expires { get{} set{} }
	public string Value { get{} set{} }
	public bool HasKeys { get{} }
	public System.Collections.Specialized.NameValueCollection Values { get{} }
	public string Item { get{} set{} }
}

