public class ContentDefinition
{

	// Constructors
	public ContentDefinition(string id, string content, string designTimeHtml) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ContentPlaceHolderID { get{} }
	public string DefaultContent { get{} }
	public string DefaultDesignTimeHtml { get{} }
}

