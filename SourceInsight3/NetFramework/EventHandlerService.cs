public class EventHandlerService : IEventHandlerService
{

	// Constructors
	public EventHandlerService(System.Windows.Forms.Control focusWnd) {}

	// Methods
	public virtual object GetHandler(Type handlerType) {}
	public virtual void PopHandler(object handler) {}
	public virtual void PushHandler(object handler) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Windows.Forms.Control FocusWindow { get{} }

	// Events
	public event System.EventHandler EventHandlerChanged;
}

