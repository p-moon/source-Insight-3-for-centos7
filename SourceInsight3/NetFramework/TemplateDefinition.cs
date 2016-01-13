public class TemplateDefinition : DesignerObject, System.IServiceProvider
{

	// Constructors
	public TemplateDefinition(ControlDesigner designer, string name, object templatedObject, string templatePropertyName) {}
	public TemplateDefinition(ControlDesigner designer, string name, object templatedObject, string templatePropertyName, System.Web.UI.WebControls.Style style) {}
	public TemplateDefinition(ControlDesigner designer, string name, object templatedObject, string templatePropertyName, bool serverControlsOnly) {}
	public TemplateDefinition(ControlDesigner designer, string name, object templatedObject, string templatePropertyName, System.Web.UI.WebControls.Style style, bool serverControlsOnly) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool AllowEditing { get{} }
	public string Content { get{} set{} }
	public bool ServerControlsOnly { get{} }
	public bool SupportsDataBinding { get{} set{} }
	public System.Web.UI.WebControls.Style Style { get{} }
	public object TemplatedObject { get{} }
	public string TemplatePropertyName { get{} }
	public ControlDesigner Designer { get{} }
	public string Name { get{} }
	public System.Collections.IDictionary Properties { get{} }
}

