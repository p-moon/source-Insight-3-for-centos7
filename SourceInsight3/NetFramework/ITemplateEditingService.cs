public interface ITemplateEditingService
{

	// Methods
	public abstract virtual ITemplateEditingFrame CreateFrame(TemplatedControlDesigner designer, string frameName, string[] templateNames) {}
	public abstract virtual ITemplateEditingFrame CreateFrame(TemplatedControlDesigner designer, string frameName, string[] templateNames, System.Web.UI.WebControls.Style controlStyle, System.Web.UI.WebControls.Style[] templateStyles) {}
	public abstract virtual string GetContainingTemplateName(System.Web.UI.Control control) {}

	// Properties
	public bool SupportsNestedTemplateEditing { get{} }
}

