public class BindingMemberInfo : System.ValueType
{

	// Constructors
	public BindingMemberInfo(string dataMember) {}

	// Methods
	public virtual bool Equals(object otherObject) {}
	public static bool op_Equality(BindingMemberInfo a, BindingMemberInfo b) {}
	public static bool op_Inequality(BindingMemberInfo a, BindingMemberInfo b) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public string BindingPath { get{} }
	public string BindingField { get{} }
	public string BindingMember { get{} }
}

