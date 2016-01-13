public class EventClassAttribute : System.Attribute, System.Runtime.InteropServices._Attribute, IConfigurationAttribute
{

	// Constructors
	public EventClassAttribute() {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool FireInParallel { get{} set{} }
	public bool AllowInprocSubscribers { get{} set{} }
	public string PublisherFilter { get{} set{} }
	public object TypeId { get{} }
}

