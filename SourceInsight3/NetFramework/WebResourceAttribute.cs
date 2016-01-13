public class WebResourceAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public WebResourceAttribute(string webResource, string contentType) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string ContentType { get{} }
	public bool PerformSubstitution { get{} set{} }
	public string WebResource { get{} }
	public object TypeId { get{} }
}

