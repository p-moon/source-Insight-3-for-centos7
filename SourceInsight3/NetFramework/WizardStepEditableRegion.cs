public class WizardStepEditableRegion : System.Web.UI.Design.EditableDesignerRegion, System.IServiceProvider, IWizardStepEditableRegion
{

	// Constructors
	public WizardStepEditableRegion(WizardDesigner designer, System.Web.UI.WebControls.WizardStepBase wizardStep) {}

	// Methods
	public virtual System.Web.UI.Design.ViewRendering GetChildViewRendering(System.Web.UI.Control control) {}
	public System.Drawing.Rectangle GetBounds() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Web.UI.WebControls.WizardStepBase Step { get{} }
	public string Content { get{} set{} }
	public bool ServerControlsOnly { get{} set{} }
	public bool SupportsDataBinding { get{} set{} }
	public string Description { get{} set{} }
	public string DisplayName { get{} set{} }
	public bool EnsureSize { get{} set{} }
	public bool Highlight { get{} set{} }
	public bool Selectable { get{} set{} }
	public bool Selected { get{} set{} }
	public object UserData { get{} set{} }
	public System.Web.UI.Design.ControlDesigner Designer { get{} }
	public string Name { get{} }
	public System.Collections.IDictionary Properties { get{} }
}

