public class Section : System.ValueType
{

	// Methods
	public virtual bool Equals(object o) {}
	public bool Equals(Section obj) {}
	public static bool op_Equality(Section a, Section b) {}
	public static bool op_Inequality(Section a, Section b) {}
	public virtual int GetHashCode() {}
	public static string ToString(Section value) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public short Mask { get{} }
	public short Offset { get{} }
}

