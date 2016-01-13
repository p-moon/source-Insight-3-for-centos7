public class Timer : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable, System.ComponentModel.ISupportInitialize
{

	// Constructors
	public Timer() {}
	public Timer(double interval) {}

	// Methods
	public virtual void BeginInit() {}
	public void Close() {}
	public virtual void EndInit() {}
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
	public bool AutoReset { get{} set{} }
	public bool Enabled { get{} set{} }
	public double Interval { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.Timers.ElapsedEventHandler Elapsed;
	public event System.EventHandler Disposed;
}

