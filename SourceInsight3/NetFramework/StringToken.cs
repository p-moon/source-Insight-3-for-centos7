public class StringToken : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public bool Equals(StringToken obj) {}
	public static bool op_Equality(StringToken a, StringToken b) {}
	public static bool op_Inequality(StringToken a, StringToken b) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public int Token { get{} }
}

