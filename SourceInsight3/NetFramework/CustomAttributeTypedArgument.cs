public class CustomAttributeTypedArgument : System.ValueType
{

	// Methods
	public static bool op_Equality(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right) {}
	public static bool op_Inequality(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right) {}
	public virtual string ToString() {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public Type GetType() {}

	// Properties
	public Type ArgumentType { get{} }
	public object Value { get{} }
}

