public class MemberRelationship : System.ValueType
{

	// Constructors
	public MemberRelationship(object owner, System.ComponentModel.MemberDescriptor member) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public static bool op_Equality(MemberRelationship left, MemberRelationship right) {}
	public static bool op_Inequality(MemberRelationship left, MemberRelationship right) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public MemberRelationship Empty;

	// Properties
	public bool IsEmpty { get{} }
	public System.ComponentModel.MemberDescriptor Member { get{} }
	public object Owner { get{} }
}

