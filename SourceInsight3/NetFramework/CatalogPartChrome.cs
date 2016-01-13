public class CatalogPartChrome
{

	// Constructors
	public CatalogPartChrome(CatalogZoneBase zone) {}

	// Methods
	public virtual void PerformPreRender() {}
	public virtual void RenderCatalogPart(System.Web.UI.HtmlTextWriter writer, CatalogPart catalogPart) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

