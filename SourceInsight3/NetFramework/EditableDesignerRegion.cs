public class EditableDesignerRegion : DesignerRegion, System.IServiceProvider
{

	// Constructors
	public EditableDesignerRegion(ControlDesigner owner, string name) {}
	public EditableDesignerRegion(ControlDesigner owner, string name, bool serverControlsOnly) {}

	// Methods
	public virtual ViewRendering GetChildViewRendering(System.Web.UI.Control control) {}
	public System.Drawing.Rectangle GetBounds() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
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
	public ControlDesigner Designer { get{} }
	public string Name { get{} }
	public System.Collections.IDictionary Properties { get{} }
}

