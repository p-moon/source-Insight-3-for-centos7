public class TemplateEditingService : ITemplateEditingService, System.IDisposable
{

	// Constructors
	public TemplateEditingService(System.ComponentModel.Design.IDesignerHost designerHost) {}

	// Methods
	public virtual ITemplateEditingFrame CreateFrame(TemplatedControlDesigner designer, string frameName, string[] templateNames) {}
	public virtual ITemplateEditingFrame CreateFrame(TemplatedControlDesigner designer, string frameName, string[] templateNames, System.Web.UI.WebControls.Style controlStyle, System.Web.UI.WebControls.Style[] templateStyles) {}
	public virtual void Dispose() {}
	public virtual string GetContainingTemplateName(System.Web.UI.Control control) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool SupportsNestedTemplateEditing { get{} }
}

