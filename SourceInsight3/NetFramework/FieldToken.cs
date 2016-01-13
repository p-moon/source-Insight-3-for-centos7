public class FieldToken : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public bool Equals(FieldToken obj) {}
	public static bool op_Equality(FieldToken a, FieldToken b) {}
	public static bool op_Inequality(FieldToken a, FieldToken b) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public FieldToken Empty;

	// Properties
	public int Token { get{} }
}

