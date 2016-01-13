public class ManagementObjectSearcher : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public ManagementObjectSearcher() {}
	public ManagementObjectSearcher(string queryString) {}
	public ManagementObjectSearcher(ObjectQuery query) {}
	public ManagementObjectSearcher(string scope, string queryString) {}
	public ManagementObjectSearcher(ManagementScope scope, ObjectQuery query) {}
	public ManagementObjectSearcher(string scope, string queryString, EnumerationOptions options) {}
	public ManagementObjectSearcher(ManagementScope scope, ObjectQuery query, EnumerationOptions options) {}

	// Methods
	public ManagementObjectCollection Get() {}
	public void Get(ManagementOperationObserver watcher) {}
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
	public ObjectQuery Query { get{} set{} }
	public EnumerationOptions Options { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Disposed;
}

