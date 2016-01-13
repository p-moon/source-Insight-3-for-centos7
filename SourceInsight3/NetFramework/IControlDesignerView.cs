public interface IControlDesignerView
{

	// Methods
	public abstract virtual System.Drawing.Rectangle GetBounds(DesignerRegion region) {}
	public abstract virtual void Invalidate(System.Drawing.Rectangle rectangle) {}
	public abstract virtual void SetFlags(ViewFlags viewFlags, bool setFlag) {}
	public abstract virtual void SetRegionContent(EditableDesignerRegion region, string content) {}
	public abstract virtual void Update() {}

	// Properties
	public DesignerRegion ContainingRegion { get{} }
	public System.ComponentModel.Design.IDesigner NamingContainerDesigner { get{} }
	public bool SupportsRegions { get{} }

	// Events
	public event System.Web.UI.Design.ViewEventHandler ViewEvent;
}

