public class DesignSurface : System.IDisposable, System.IServiceProvider
{

	// Constructors
	public DesignSurface() {}
	public DesignSurface(System.IServiceProvider parentProvider) {}
	public DesignSurface(Type rootComponentType) {}
	public DesignSurface(System.IServiceProvider parentProvider, Type rootComponentType) {}

	// Methods
	public void BeginLoad(System.ComponentModel.Design.Serialization.DesignerLoader loader) {}
	public void BeginLoad(Type rootComponentType) {}
	public System.ComponentModel.INestedContainer CreateNestedContainer(System.ComponentModel.IComponent owningComponent) {}
	public System.ComponentModel.INestedContainer CreateNestedContainer(System.ComponentModel.IComponent owningComponent, string containerName) {}
	public virtual void Dispose() {}
	public void Flush() {}
	public virtual object GetService(Type serviceType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.ComponentModel.IContainer ComponentContainer { get{} }
	public bool IsLoaded { get{} }
	public System.Collections.ICollection LoadErrors { get{} }
	public object View { get{} }

	// Events
	public event System.EventHandler Disposed;
	public event System.EventHandler Flushed;
	public event System.ComponentModel.Design.LoadedEventHandler Loaded;
	public event System.EventHandler Loading;
	public event System.EventHandler Unloaded;
	public event System.EventHandler Unloading;
	public event System.EventHandler ViewActivated;
}

