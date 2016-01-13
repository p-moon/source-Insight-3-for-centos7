public class EventWatcherOptions : ManagementOptions, System.ICloneable
{

	// Constructors
	public EventWatcherOptions() {}
	public EventWatcherOptions(ManagementNamedValueCollection context, System.TimeSpan timeout, int blockSize) {}

	// Methods
	public virtual object Clone() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int BlockSize { get{} set{} }
	public ManagementNamedValueCollection Context { get{} set{} }
	public System.TimeSpan Timeout { get{} set{} }
}

