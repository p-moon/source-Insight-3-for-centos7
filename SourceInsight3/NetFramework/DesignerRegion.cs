public class DesignerRegion : DesignerObject, System.IServiceProvider
{

	// Constructors
	public DesignerRegion(ControlDesigner designer, string name) {}
	public DesignerRegion(ControlDesigner designer, string name, bool selectable) {}

	// Methods
	public System.Drawing.Rectangle GetBounds() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string DesignerRegionAttributeName;

	// Properties
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

