public class Component : System.MarshalByRefObject, IComponent, System.IDisposable
{

	// Constructors
	public Component() {}

	// Methods
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ISite Site { get{} set{} }
	public IContainer Container { get{} }

	// Events
	public event System.EventHandler Disposed;
}

