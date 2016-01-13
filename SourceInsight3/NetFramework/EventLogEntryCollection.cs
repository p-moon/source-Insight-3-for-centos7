public class EventLogEntryCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public void CopyTo(EventLogEntry[] entries, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public EventLogEntry Item { get{} }
}

