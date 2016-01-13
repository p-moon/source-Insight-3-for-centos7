public class EntryWrittenEventArgs : System.EventArgs
{

	// Constructors
	public EntryWrittenEventArgs() {}
	public EntryWrittenEventArgs(EventLogEntry entry) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public EventLogEntry Entry { get{} }
}

