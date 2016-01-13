public class InstrumentationClassAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public InstrumentationClassAttribute(InstrumentationType instrumentationType) {}
	public InstrumentationClassAttribute(InstrumentationType instrumentationType, string managedBaseClassName) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public InstrumentationType InstrumentationType { get{} }
	public string ManagedBaseClassName { get{} }
	public object TypeId { get{} }
}

