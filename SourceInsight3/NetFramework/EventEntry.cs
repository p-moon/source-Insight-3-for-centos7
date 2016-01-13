public class EventEntry
{

	// Constructors
	public EventEntry() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string HandlerMethodName { get{} set{} }
	public Type HandlerType { get{} set{} }
	public string Name { get{} set{} }
}

