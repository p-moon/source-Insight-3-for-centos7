public class OracleString : System.ValueType, System.IComparable, System.Data.SqlTypes.INullable
{

	// Constructors
	public OracleString(string s) {}

	// Methods
	public virtual int CompareTo(object obj) {}
	public virtual bool Equals(object value) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public static OracleString Concat(OracleString x, OracleString y) {}
	public static OracleBoolean Equals(OracleString x, OracleString y) {}
	public static OracleBoolean GreaterThan(OracleString x, OracleString y) {}
	public static OracleBoolean GreaterThanOrEqual(OracleString x, OracleString y) {}
	public static OracleBoolean LessThan(OracleString x, OracleString y) {}
	public static OracleBoolean LessThanOrEqual(OracleString x, OracleString y) {}
	public static OracleBoolean NotEquals(OracleString x, OracleString y) {}
	public static OracleString op_Implicit(string s) {}
	public static string op_Explicit(OracleString x) {}
	public static OracleString op_Addition(OracleString x, OracleString y) {}
	public static OracleBoolean op_Equality(OracleString x, OracleString y) {}
	public static OracleBoolean op_GreaterThan(OracleString x, OracleString y) {}
	public static OracleBoolean op_GreaterThanOrEqual(OracleString x, OracleString y) {}
	public static OracleBoolean op_LessThan(OracleString x, OracleString y) {}
	public static OracleBoolean op_LessThanOrEqual(OracleString x, OracleString y) {}
	public static OracleBoolean op_Inequality(OracleString x, OracleString y) {}
	public Type GetType() {}

	// Fields
	public OracleString Empty;
	public OracleString Null;

	// Properties
	public bool IsNull { get{} }
	public int Length { get{} }
	public string Value { get{} }
	public char Item { get{} }
}

