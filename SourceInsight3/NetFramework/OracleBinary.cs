public class OracleBinary : System.ValueType, System.IComparable, System.Data.SqlTypes.INullable
{

	// Constructors
	public OracleBinary(byte[] b) {}

	// Methods
	public virtual int CompareTo(object obj) {}
	public virtual bool Equals(object value) {}
	public virtual int GetHashCode() {}
	public static OracleBinary Concat(OracleBinary x, OracleBinary y) {}
	public static OracleBoolean Equals(OracleBinary x, OracleBinary y) {}
	public static OracleBoolean GreaterThan(OracleBinary x, OracleBinary y) {}
	public static OracleBoolean GreaterThanOrEqual(OracleBinary x, OracleBinary y) {}
	public static OracleBoolean LessThan(OracleBinary x, OracleBinary y) {}
	public static OracleBoolean LessThanOrEqual(OracleBinary x, OracleBinary y) {}
	public static OracleBoolean NotEquals(OracleBinary x, OracleBinary y) {}
	public static OracleBinary op_Implicit(byte[] b) {}
	public static byte[] op_Explicit(OracleBinary x) {}
	public static OracleBinary op_Addition(OracleBinary x, OracleBinary y) {}
	public static OracleBoolean op_Equality(OracleBinary x, OracleBinary y) {}
	public static OracleBoolean op_GreaterThan(OracleBinary x, OracleBinary y) {}
	public static OracleBoolean op_GreaterThanOrEqual(OracleBinary x, OracleBinary y) {}
	public static OracleBoolean op_LessThan(OracleBinary x, OracleBinary y) {}
	public static OracleBoolean op_LessThanOrEqual(OracleBinary x, OracleBinary y) {}
	public static OracleBoolean op_Inequality(OracleBinary x, OracleBinary y) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public OracleBinary Null;

	// Properties
	public bool IsNull { get{} }
	public int Length { get{} }
	public byte[] Value { get{} }
	public byte Item { get{} }
}

