public class ServiceBase : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public ServiceBase() {}

	// Methods
	public void RequestAdditionalTime(int milliseconds) {}
	public static void Run(ServiceBase[] services) {}
	public static void Run(ServiceBase service) {}
	public void Stop() {}
	public void ServiceMainCallback(int argCount, System.IntPtr argPointer) {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int MaxNameLength;

	// Properties
	public bool AutoLog { get{} set{} }
	public int ExitCode { get{} set{} }
	public bool CanHandlePowerEvent { get{} set{} }
	public bool CanHandleSessionChangeEvent { get{} set{} }
	public bool CanPauseAndContinue { get{} set{} }
	public bool CanShutdown { get{} set{} }
	public bool CanStop { get{} set{} }
	public System.Diagnostics.EventLog EventLog { get{} }
	public string ServiceName { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Disposed;
}

