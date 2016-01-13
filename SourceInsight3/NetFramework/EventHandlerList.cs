public class EventHandlerList : System.IDisposable
{

	// Constructors
	public EventHandlerList() {}

	// Methods
	public void AddHandler(object key, System.Delegate value) {}
	public void AddHandlers(EventHandlerList listToAddFrom) {}
	public virtual void Dispose() {}
	public void RemoveHandler(object key, System.Delegate value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Delegate Item { get{} set{} }
}

