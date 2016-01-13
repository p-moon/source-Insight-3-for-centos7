public class OracleMonthSpan : System.ValueType, System.IComparable, System.Data.SqlTypes.INullable
{

	// Constructors
	public OracleMonthSpan(int months) {}
	public OracleMonthSpan(int years, int months) {}
	public OracleMonthSpan(OracleMonthSpan from) {}

	// Methods
	public virtual int CompareTo(object obj) {}
	public virtual bool Equals(object value) {}
	public virtual int GetHashCode() {}
	public static OracleMonthSpan Parse(string s) {}
	public virtual string ToString() {}
	public static OracleBoolean Equals(OracleMonthSpan x, OracleMonthSpan y) {}
	public static OracleBoolean GreaterThan(OracleMonthSpan x, OracleMonthSpan y) {}
	public static OracleBoolean GreaterThanOrEqual(OracleMonthSpan x, OracleMonthSpan y) {}
	public static OracleBoolean LessThan(OracleMonthSpan x, OracleMonthSpan y) {}
	public static OracleBoolean LessThanOrEqual(OracleMonthSpan x, OracleMonthSpan y) {}
	public static OracleBoolean NotEquals(OracleMonthSpan x, OracleMonthSpan y) {}
	public static int op_Explicit(OracleMonthSpan x) {}
	public static OracleMonthSpan op_Explicit(string x) {}
	public static OracleBoolean op_Equality(OracleMonthSpan x, OracleMonthSpan y) {}
	public static OracleBoolean op_GreaterThan(OracleMonthSpan x, OracleMonthSpan y) {}
	public static OracleBoolean op_GreaterThanOrEqual(OracleMonthSpan x, OracleMonthSpan y) {}
	public static OracleBoolean op_LessThan(OracleMonthSpan x, OracleMonthSpan y) {}
	public static OracleBoolean op_LessThanOrEqual(OracleMonthSpan x, OracleMonthSpan y) {}
	public static OracleBoolean op_Inequality(OracleMonthSpan x, OracleMonthSpan y) {}
	public Type GetType() {}

	// Fields
	public OracleMonthSpan MaxValue;
	public OracleMonthSpan MinValue;
	public OracleMonthSpan Null;

	// Properties
	public bool IsNull { get{} }
	public int Value { get{} }
}

