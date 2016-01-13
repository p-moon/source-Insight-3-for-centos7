public class WebContext
{

	// Constructors
	public WebContext(WebApplicationLevel pathLevel, string site, string applicationPath, string path, string locationSubPath, string appConfigPath) {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public WebApplicationLevel ApplicationLevel { get{} }
	public string Site { get{} }
	public string ApplicationPath { get{} }
	public string Path { get{} }
	public string LocationSubPath { get{} }
}

