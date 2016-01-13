public class DesignSurfaceEventArgs : System.EventArgs
{

	// Constructors
	public DesignSurfaceEventArgs(DesignSurface surface) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DesignSurface Surface { get{} }
}

