public class WebPartChrome
{

	// Constructors
	public WebPartChrome(WebPartZoneBase zone, WebPartManager manager) {}

	// Methods
	public virtual void PerformPreRender() {}
	public virtual void RenderWebPart(System.Web.UI.HtmlTextWriter writer, WebPart webPart) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

