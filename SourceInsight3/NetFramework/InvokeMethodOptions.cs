public class InvokeMethodOptions : ManagementOptions, System.ICloneable
{

	// Constructors
	public InvokeMethodOptions() {}
	public InvokeMethodOptions(ManagementNamedValueCollection context, System.TimeSpan timeout) {}

	// Methods
	public virtual object Clone() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ManagementNamedValueCollection Context { get{} set{} }
	public System.TimeSpan Timeout { get{} set{} }
}

