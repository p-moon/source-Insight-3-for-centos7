public class ArrayWithOffset : System.ValueType
{

	// Constructors
	public ArrayWithOffset(object array, int offset) {}

	// Methods
	public object GetArray() {}
	public int GetOffset() {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public bool Equals(ArrayWithOffset obj) {}
	public static bool op_Equality(ArrayWithOffset a, ArrayWithOffset b) {}
	public static bool op_Inequality(ArrayWithOffset a, ArrayWithOffset b) {}
	public virtual string ToString() {}
	public Type GetType() {}
}

