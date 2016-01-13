public class FileSystemWatcher : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable, System.ComponentModel.ISupportInitialize
{

	// Constructors
	public FileSystemWatcher() {}
	public FileSystemWatcher(string path) {}
	public FileSystemWatcher(string path, string filter) {}

	// Methods
	public virtual void BeginInit() {}
	public virtual void EndInit() {}
	public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType) {}
	public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType, int timeout) {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public NotifyFilters NotifyFilter { get{} set{} }
	public bool EnableRaisingEvents { get{} set{} }
	public string Filter { get{} set{} }
	public bool IncludeSubdirectories { get{} set{} }
	public int InternalBufferSize { get{} set{} }
	public string Path { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.IO.FileSystemEventHandler Changed;
	public event System.IO.FileSystemEventHandler Created;
	public event System.IO.FileSystemEventHandler Deleted;
	public event System.IO.ErrorEventHandler Error;
	public event System.IO.RenamedEventHandler Renamed;
	public event System.EventHandler Disposed;
}

