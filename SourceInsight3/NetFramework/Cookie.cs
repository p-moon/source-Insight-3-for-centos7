public class Cookie
{

	// Constructors
	public Cookie() {}
	public Cookie(string name, string value) {}
	public Cookie(string name, string value, string path) {}
	public Cookie(string name, string value, string path, string domain) {}

	// Methods
	public virtual bool Equals(object comparand) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public string Comment { get{} set{} }
	public System.Uri CommentUri { get{} set{} }
	public bool HttpOnly { get{} set{} }
	public bool Discard { get{} set{} }
	public string Domain { get{} set{} }
	public bool Expired { get{} set{} }
	public System.DateTime Expires { get{} set{} }
	public string Name { get{} set{} }
	public string Path { get{} set{} }
	public string Port { get{} set{} }
	public bool Secure { get{} set{} }
	public System.DateTime TimeStamp { get{} }
	public string Value { get{} set{} }
	public int Version { get{} set{} }
}

