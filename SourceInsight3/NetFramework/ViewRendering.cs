public class ViewRendering
{

	// Constructors
	public ViewRendering(string content, DesignerRegionCollection regions) {}
	public ViewRendering(string content, DesignerRegionCollection regions, bool visible) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Content { get{} }
	public DesignerRegionCollection Regions { get{} }
	public bool Visible { get{} }
}

