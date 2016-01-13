public class ManagementEventWatcher : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public ManagementEventWatcher() {}
	public ManagementEventWatcher(EventQuery query) {}
	public ManagementEventWatcher(string query) {}
	public ManagementEventWatcher(ManagementScope scope, EventQuery query) {}
	public ManagementEventWatcher(string scope, string query) {}
	public ManagementEventWatcher(string scope, string query, EventWatcherOptions options) {}
	public ManagementEventWatcher(ManagementScope scope, EventQuery query, EventWatcherOptions options) {}

	// Methods
	public ManagementBaseObject WaitForNextEvent() {}
	public void Start() {}
	public void Stop() {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ManagementScope Scope { get{} set{} }
	public EventQuery Query { get{} set{} }
	public EventWatcherOptions Options { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.Management.EventArrivedEventHandler EventArrived;
	public event System.Management.StoppedEventHandler Stopped;
	public event System.EventHandler Disposed;
}

