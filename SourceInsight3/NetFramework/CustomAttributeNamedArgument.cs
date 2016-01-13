public class CustomAttributeNamedArgument : System.ValueType
{

	// Methods
	public static bool op_Equality(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right) {}
	public static bool op_Inequality(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right) {}
	public virtual string ToString() {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public Type GetType() {}

	// Properties
	public MemberInfo MemberInfo { get{} }
	public CustomAttributeTypedArgument TypedValue { get{} }
}

