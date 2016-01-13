public class PropertyToken : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public bool Equals(PropertyToken obj) {}
	public static bool op_Equality(PropertyToken a, PropertyToken b) {}
	public static bool op_Inequality(PropertyToken a, PropertyToken b) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public PropertyToken Empty;

	// Properties
	public int Token { get{} }
}

