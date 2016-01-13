public class EventLog : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable, System.ComponentModel.ISupportInitialize
{

	// Constructors
	public EventLog() {}
	public EventLog(string logName) {}
	public EventLog(string logName, string machineName) {}
	public EventLog(string logName, string machineName, string source) {}

	// Methods
	public virtual void BeginInit() {}
	public void Clear() {}
	public void Close() {}
	public static void CreateEventSource(string source, string logName) {}
	public static void CreateEventSource(string source, string logName, string machineName) {}
	public static void CreateEventSource(EventSourceCreationData sourceData) {}
	public static void Delete(string logName) {}
	public static void Delete(string logName, string machineName) {}
	public static void DeleteEventSource(string source) {}
	public static void DeleteEventSource(string source, string machineName) {}
	public virtual void EndInit() {}
	public static bool Exists(string logName) {}
	public static bool Exists(string logName, string machineName) {}
	public static EventLog[] GetEventLogs() {}
	public static EventLog[] GetEventLogs(string machineName) {}
	public static bool SourceExists(string source) {}
	public static bool SourceExists(string source, string machineName) {}
	public static string LogNameFromSourceName(string source, string machineName) {}
	public void ModifyOverflowPolicy(OverflowAction action, int retentionDays) {}
	public void RegisterDisplayName(string resourceFile, long resourceId) {}
	public void WriteEntry(string message) {}
	public static void WriteEntry(string source, string message) {}
	public void WriteEntry(string message, EventLogEntryType type) {}
	public static void WriteEntry(string source, string message, EventLogEntryType type) {}
	public void WriteEntry(string message, EventLogEntryType type, int eventID) {}
	public static void WriteEntry(string source, string message, EventLogEntryType type, int eventID) {}
	public void WriteEntry(string message, EventLogEntryType type, int eventID, short category) {}
	public static void WriteEntry(string source, string message, EventLogEntryType type, int eventID, short category) {}
	public static void WriteEntry(string source, string message, EventLogEntryType type, int eventID, short category, byte[] rawData) {}
	public void WriteEntry(string message, EventLogEntryType type, int eventID, short category, byte[] rawData) {}
	public void WriteEvent(EventInstance instance, object[] values) {}
	public void WriteEvent(EventInstance instance, byte[] data, object[] values) {}
	public static void WriteEvent(string source, EventInstance instance, object[] values) {}
	public static void WriteEvent(string source, EventInstance instance, byte[] data, object[] values) {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public EventLogEntryCollection Entries { get{} }
	public string LogDisplayName { get{} }
	public string Log { get{} set{} }
	public string MachineName { get{} set{} }
	public long MaximumKilobytes { get{} set{} }
	public OverflowAction OverflowAction { get{} }
	public int MinimumRetentionDays { get{} }
	public bool EnableRaisingEvents { get{} set{} }
	public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get{} set{} }
	public string Source { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.Diagnostics.EntryWrittenEventHandler EntryWritten;
	public event System.EventHandler Disposed;
}

