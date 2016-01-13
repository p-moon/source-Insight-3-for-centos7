public class ContentType
{

	// Constructors
	public ContentType() {}
	public ContentType(string contentType) {}

	// Methods
	public virtual string ToString() {}
	public virtual bool Equals(object rparam) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}

	// Properties
	public string Boundary { get{} set{} }
	public string CharSet { get{} set{} }
	public string MediaType { get{} set{} }
	public string Name { get{} set{} }
	public System.Collections.Specialized.StringDictionary Parameters { get{} }
}

