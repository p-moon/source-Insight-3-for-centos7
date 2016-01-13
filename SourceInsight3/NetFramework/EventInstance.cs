public class EventInstance
{

	// Constructors
	public EventInstance(long instanceId, int categoryId) {}
	public EventInstance(long instanceId, int categoryId, EventLogEntryType entryType) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int CategoryId { get{} set{} }
	public EventLogEntryType EntryType { get{} set{} }
	public long InstanceId { get{} set{} }
}

