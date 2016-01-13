public class SymbolToken : System.ValueType
{

	// Constructors
	public SymbolToken(int val) {}

	// Methods
	public int GetToken() {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public bool Equals(SymbolToken obj) {}
	public static bool op_Equality(SymbolToken a, SymbolToken b) {}
	public static bool op_Inequality(SymbolToken a, SymbolToken b) {}
	public virtual string ToString() {}
	public Type GetType() {}
}

