public class PageStatePersister
{

	// Methods
	public abstract virtual void Load() {}
	public abstract virtual void Save() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object ControlState { get{} set{} }
	public object ViewState { get{} set{} }
}

