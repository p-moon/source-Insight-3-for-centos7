public class PutOptions : ManagementOptions, System.ICloneable
{

	// Constructors
	public PutOptions() {}
	public PutOptions(ManagementNamedValueCollection context) {}
	public PutOptions(ManagementNamedValueCollection context, System.TimeSpan timeout, bool useAmendedQualifiers, PutType putType) {}

	// Methods
	public virtual object Clone() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool UseAmendedQualifiers { get{} set{} }
	public PutType Type { get{} set{} }
	public ManagementNamedValueCollection Context { get{} set{} }
	public System.TimeSpan Timeout { get{} set{} }
}

