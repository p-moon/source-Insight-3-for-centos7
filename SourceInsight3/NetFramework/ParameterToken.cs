public class ParameterToken : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public bool Equals(ParameterToken obj) {}
	public static bool op_Equality(ParameterToken a, ParameterToken b) {}
	public static bool op_Inequality(ParameterToken a, ParameterToken b) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public ParameterToken Empty;

	// Properties
	public int Token { get{} }
}

