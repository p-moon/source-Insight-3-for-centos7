public class PerformanceCounter : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable, System.ComponentModel.ISupportInitialize
{

	// Constructors
	public PerformanceCounter() {}
	public PerformanceCounter(string categoryName, string counterName, string instanceName, string machineName) {}
	public PerformanceCounter(string categoryName, string counterName, string instanceName) {}
	public PerformanceCounter(string categoryName, string counterName, string instanceName, bool readOnly) {}
	public PerformanceCounter(string categoryName, string counterName) {}
	public PerformanceCounter(string categoryName, string counterName, bool readOnly) {}

	// Methods
	public virtual void BeginInit() {}
	public void Close() {}
	public static void CloseSharedResources() {}
	public long Decrement() {}
	public virtual void EndInit() {}
	public long IncrementBy(long value) {}
	public long Increment() {}
	public CounterSample NextSample() {}
	public float NextValue() {}
	public void RemoveInstance() {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int DefaultFileMappingSize;

	// Properties
	public string CategoryName { get{} set{} }
	public string CounterHelp { get{} }
	public string CounterName { get{} set{} }
	public PerformanceCounterType CounterType { get{} }
	public PerformanceCounterInstanceLifetime InstanceLifetime { get{} set{} }
	public string InstanceName { get{} set{} }
	public bool ReadOnly { get{} set{} }
	public string MachineName { get{} set{} }
	public long RawValue { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Disposed;
}

