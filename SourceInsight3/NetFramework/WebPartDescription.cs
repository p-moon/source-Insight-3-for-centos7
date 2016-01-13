public class WebPartDescription
{

	// Constructors
	public WebPartDescription(string id, string title, string description, string imageUrl) {}
	public WebPartDescription(WebPart part) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string CatalogIconImageUrl { get{} }
	public string Description { get{} }
	public string ID { get{} }
	public string Title { get{} }
}

