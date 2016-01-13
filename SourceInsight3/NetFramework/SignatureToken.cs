public class SignatureToken : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public bool Equals(SignatureToken obj) {}
	public static bool op_Equality(SignatureToken a, SignatureToken b) {}
	public static bool op_Inequality(SignatureToken a, SignatureToken b) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public SignatureToken Empty;

	// Properties
	public int Token { get{} }
}

