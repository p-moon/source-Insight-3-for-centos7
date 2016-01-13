public class ProcessThread : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable
{

	// Methods
	public void ResetIdealProcessor() {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int BasePriority { get{} }
	public int CurrentPriority { get{} }
	public int Id { get{} }
	public int IdealProcessor { set{} }
	public bool PriorityBoostEnabled { get{} set{} }
	public ThreadPriorityLevel PriorityLevel { get{} set{} }
	public System.TimeSpan PrivilegedProcessorTime { get{} }
	public System.IntPtr StartAddress { get{} }
	public System.DateTime StartTime { get{} }
	public ThreadState ThreadState { get{} }
	public System.TimeSpan TotalProcessorTime { get{} }
	public System.TimeSpan UserProcessorTime { get{} }
	public ThreadWaitReason WaitReason { get{} }
	public System.IntPtr ProcessorAffinity { set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Disposed;
}

