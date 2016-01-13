public class TypeToken : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public bool Equals(TypeToken obj) {}
	public static bool op_Equality(TypeToken a, TypeToken b) {}
	public static bool op_Inequality(TypeToken a, TypeToken b) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public TypeToken Empty;

	// Properties
	public int Token { get{} }
}

