public class MethodToken : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public bool Equals(MethodToken obj) {}
	public static bool op_Equality(MethodToken a, MethodToken b) {}
	public static bool op_Inequality(MethodToken a, MethodToken b) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public MethodToken Empty;

	// Properties
	public int Token { get{} }
}

