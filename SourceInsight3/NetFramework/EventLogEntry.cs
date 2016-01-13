public class EventLogEntry : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable, System.Runtime.Serialization.ISerializable
{

	// Methods
	public bool Equals(EventLogEntry otherEntry) {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string MachineName { get{} }
	public byte[] Data { get{} }
	public int Index { get{} }
	public string Category { get{} }
	public short CategoryNumber { get{} }
	public int EventID { get{} }
	public EventLogEntryType EntryType { get{} }
	public string Message { get{} }
	public string Source { get{} }
	public string[] ReplacementStrings { get{} }
	public long InstanceId { get{} }
	public System.DateTime TimeGenerated { get{} }
	public System.DateTime TimeWritten { get{} }
	public string UserName { get{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Disposed;
}

