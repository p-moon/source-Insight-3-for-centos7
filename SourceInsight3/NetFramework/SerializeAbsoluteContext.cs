public class SerializeAbsoluteContext
{

	// Constructors
	public SerializeAbsoluteContext() {}
	public SerializeAbsoluteContext(System.ComponentModel.MemberDescriptor member) {}

	// Methods
	public bool ShouldSerialize(System.ComponentModel.MemberDescriptor member) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.ComponentModel.MemberDescriptor Member { get{} }
}

