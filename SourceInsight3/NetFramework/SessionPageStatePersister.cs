public class SessionPageStatePersister : PageStatePersister
{

	// Constructors
	public SessionPageStatePersister(Page page) {}

	// Methods
	public virtual void Load() {}
	public virtual void Save() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object ControlState { get{} set{} }
	public object ViewState { get{} set{} }
}

