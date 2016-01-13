public class OracleBoolean : System.ValueType, System.IComparable
{

	// Constructors
	public OracleBoolean(bool value) {}
	public OracleBoolean(int value) {}

	// Methods
	public virtual int CompareTo(object obj) {}
	public virtual bool Equals(object value) {}
	public virtual int GetHashCode() {}
	public static OracleBoolean Parse(string s) {}
	public virtual string ToString() {}
	public static OracleBoolean And(OracleBoolean x, OracleBoolean y) {}
	public static OracleBoolean Equals(OracleBoolean x, OracleBoolean y) {}
	public static OracleBoolean NotEquals(OracleBoolean x, OracleBoolean y) {}
	public static OracleBoolean OnesComplement(OracleBoolean x) {}
	public static OracleBoolean Or(OracleBoolean x, OracleBoolean y) {}
	public static OracleBoolean Xor(OracleBoolean x, OracleBoolean y) {}
	public static OracleBoolean op_Implicit(bool x) {}
	public static OracleBoolean op_Explicit(string x) {}
	public static OracleBoolean op_Explicit(OracleNumber x) {}
	public static bool op_Explicit(OracleBoolean x) {}
	public static OracleBoolean op_LogicalNot(OracleBoolean x) {}
	public static OracleBoolean op_OnesComplement(OracleBoolean x) {}
	public static bool op_True(OracleBoolean x) {}
	public static bool op_False(OracleBoolean x) {}
	public static OracleBoolean op_BitwiseAnd(OracleBoolean x, OracleBoolean y) {}
	public static OracleBoolean op_Equality(OracleBoolean x, OracleBoolean y) {}
	public static OracleBoolean op_Inequality(OracleBoolean x, OracleBoolean y) {}
	public static OracleBoolean op_BitwiseOr(OracleBoolean x, OracleBoolean y) {}
	public static OracleBoolean op_ExclusiveOr(OracleBoolean x, OracleBoolean y) {}
	public Type GetType() {}

	// Fields
	public OracleBoolean False;
	public OracleBoolean Null;
	public OracleBoolean One;
	public OracleBoolean True;
	public OracleBoolean Zero;

	// Properties
	public bool IsFalse { get{} }
	public bool IsNull { get{} }
	public bool IsTrue { get{} }
	public bool Value { get{} }
}

