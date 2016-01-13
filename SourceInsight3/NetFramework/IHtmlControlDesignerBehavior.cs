public interface IHtmlControlDesignerBehavior
{

	// Methods
	public abstract virtual object GetAttribute(string attribute, bool ignoreCase) {}
	public abstract virtual void RemoveAttribute(string attribute, bool ignoreCase) {}
	public abstract virtual void SetAttribute(string attribute, object value, bool ignoreCase) {}
	public abstract virtual object GetStyleAttribute(string attribute, bool designTimeOnly, bool ignoreCase) {}
	public abstract virtual void RemoveStyleAttribute(string attribute, bool designTimeOnly, bool ignoreCase) {}
	public abstract virtual void SetStyleAttribute(string attribute, bool designTimeOnly, object value, bool ignoreCase) {}

	// Properties
	public HtmlControlDesigner Designer { get{} set{} }
	public object DesignTimeElement { get{} }
}

