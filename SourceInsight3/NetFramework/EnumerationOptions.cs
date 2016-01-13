public class EnumerationOptions : ManagementOptions, System.ICloneable
{

	// Constructors
	public EnumerationOptions() {}
	public EnumerationOptions(ManagementNamedValueCollection context, System.TimeSpan timeout, int blockSize, bool rewindable, bool returnImmediatley, bool useAmendedQualifiers, bool ensureLocatable, bool prototypeOnly, bool directRead, bool enumerateDeep) {}

	// Methods
	public virtual object Clone() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool ReturnImmediately { get{} set{} }
	public int BlockSize { get{} set{} }
	public bool Rewindable { get{} set{} }
	public bool UseAmendedQualifiers { get{} set{} }
	public bool EnsureLocatable { get{} set{} }
	public bool PrototypeOnly { get{} set{} }
	public bool DirectRead { get{} set{} }
	public bool EnumerateDeep { get{} set{} }
	public ManagementNamedValueCollection Context { get{} set{} }
	public System.TimeSpan Timeout { get{} set{} }
}

