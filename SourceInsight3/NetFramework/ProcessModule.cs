public class ProcessModule : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable
{

	// Methods
	public virtual string ToString() {}
	public virtual void Dispose() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ModuleName { get{} }
	public string FileName { get{} }
	public System.IntPtr BaseAddress { get{} }
	public int ModuleMemorySize { get{} }
	public System.IntPtr EntryPointAddress { get{} }
	public FileVersionInfo FileVersionInfo { get{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Disposed;
}

