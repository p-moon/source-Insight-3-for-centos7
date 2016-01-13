public class ExpressionBuilderContext
{

	// Constructors
	public ExpressionBuilderContext(string virtualPath) {}
	public ExpressionBuilderContext(System.Web.UI.TemplateControl templateControl) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Web.UI.TemplateControl TemplateControl { get{} }
	public string VirtualPath { get{} }
}

