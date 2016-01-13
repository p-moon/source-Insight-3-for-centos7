public class DesignSurfaceManager : System.IServiceProvider, System.IDisposable
{

	// Constructors
	public DesignSurfaceManager() {}
	public DesignSurfaceManager(System.IServiceProvider parentProvider) {}

	// Methods
	public DesignSurface CreateDesignSurface() {}
	public DesignSurface CreateDesignSurface(System.IServiceProvider parentProvider) {}
	public virtual void Dispose() {}
	public virtual object GetService(Type serviceType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DesignSurface ActiveDesignSurface { get{} set{} }
	public DesignSurfaceCollection DesignSurfaces { get{} }

	// Events
	public event System.ComponentModel.Design.ActiveDesignSurfaceChangedEventHandler ActiveDesignSurfaceChanged;
	public event System.ComponentModel.Design.DesignSurfaceEventHandler DesignSurfaceCreated;
	public event System.ComponentModel.Design.DesignSurfaceEventHandler DesignSurfaceDisposed;
	public event System.EventHandler SelectionChanged;
}

