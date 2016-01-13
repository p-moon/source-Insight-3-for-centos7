public class ReliabilityContractAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ReliabilityContractAttribute(Consistency consistencyGuarantee, Cer cer) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public Consistency ConsistencyGuarantee { get{} }
	public Cer Cer { get{} }
	public object TypeId { get{} }
}

