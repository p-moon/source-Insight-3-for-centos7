public class ServiceController : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public ServiceController() {}
	public ServiceController(string name) {}
	public ServiceController(string name, string machineName) {}

	// Methods
	public void Close() {}
	public static ServiceController[] GetDevices() {}
	public static ServiceController[] GetDevices(string machineName) {}
	public static ServiceController[] GetServices() {}
	public static ServiceController[] GetServices(string machineName) {}
	public void Pause() {}
	public void Continue() {}
	public void ExecuteCommand(int command) {}
	public void Refresh() {}
	public void Start() {}
	public void Start(string[] args) {}
	public void Stop() {}
	public void WaitForStatus(ServiceControllerStatus desiredStatus) {}
	public void WaitForStatus(ServiceControllerStatus desiredStatus, System.TimeSpan timeout) {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool CanPauseAndContinue { get{} }
	public bool CanShutdown { get{} }
	public bool CanStop { get{} }
	public string DisplayName { get{} set{} }
	public ServiceController[] DependentServices { get{} }
	public string MachineName { get{} set{} }
	public string ServiceName { get{} set{} }
	public ServiceController[] ServicesDependedOn { get{} }
	public System.Runtime.InteropServices.SafeHandle ServiceHandle { get{} }
	public ServiceControllerStatus Status { get{} }
	public ServiceType ServiceType { get{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Disposed;
}

