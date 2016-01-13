public class ActiveDesignSurfaceChangedEventArgs : System.EventArgs
{

	// Constructors
	public ActiveDesignSurfaceChangedEventArgs(DesignSurface oldSurface, DesignSurface newSurface) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DesignSurface OldSurface { get{} }
	public DesignSurface NewSurface { get{} }
}

