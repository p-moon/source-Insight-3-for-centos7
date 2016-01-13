public class DesignerRegionMouseEventArgs : System.EventArgs
{

	// Constructors
	public DesignerRegionMouseEventArgs(DesignerRegion region, System.Drawing.Point location) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Point Location { get{} }
	public DesignerRegion Region { get{} }
}

