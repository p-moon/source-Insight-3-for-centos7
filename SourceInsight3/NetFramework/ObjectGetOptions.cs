public class ObjectGetOptions : ManagementOptions, System.ICloneable
{

	// Constructors
	public ObjectGetOptions() {}
	public ObjectGetOptions(ManagementNamedValueCollection context) {}
	public ObjectGetOptions(ManagementNamedValueCollection context, System.TimeSpan timeout, bool useAmendedQualifiers) {}

	// Methods
	public virtual object Clone() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool UseAmendedQualifiers { get{} set{} }
	public ManagementNamedValueCollection Context { get{} set{} }
	public System.TimeSpan Timeout { get{} set{} }
}

