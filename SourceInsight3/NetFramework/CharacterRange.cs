public class CharacterRange : System.ValueType
{

	// Constructors
	public CharacterRange(int First, int Length) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public static bool op_Equality(CharacterRange cr1, CharacterRange cr2) {}
	public static bool op_Inequality(CharacterRange cr1, CharacterRange cr2) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public int First { get{} set{} }
	public int Length { get{} set{} }
}

