public class ApplicationQueuingAttribute : System.Attribute, System.Runtime.InteropServices._Attribute, IConfigurationAttribute
{

	// Constructors
	public ApplicationQueuingAttribute() {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool Enabled { get{} set{} }
	public bool QueueListenerEnabled { get{} set{} }
	public int MaxListenerThreads { get{} set{} }
	public object TypeId { get{} }
}

