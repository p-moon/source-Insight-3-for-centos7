public class OracleTimeSpan : System.ValueType, System.IComparable, System.Data.SqlTypes.INullable
{

	// Constructors
	public OracleTimeSpan(System.TimeSpan ts) {}
	public OracleTimeSpan(long ticks) {}
	public OracleTimeSpan(int hours, int minutes, int seconds) {}
	public OracleTimeSpan(int days, int hours, int minutes, int seconds) {}
	public OracleTimeSpan(int days, int hours, int minutes, int seconds, int milliseconds) {}
	public OracleTimeSpan(OracleTimeSpan from) {}

	// Methods
	public virtual int CompareTo(object obj) {}
	public virtual bool Equals(object value) {}
	public virtual int GetHashCode() {}
	public static OracleTimeSpan Parse(string s) {}
	public virtual string ToString() {}
	public static OracleBoolean Equals(OracleTimeSpan x, OracleTimeSpan y) {}
	public static OracleBoolean GreaterThan(OracleTimeSpan x, OracleTimeSpan y) {}
	public static OracleBoolean GreaterThanOrEqual(OracleTimeSpan x, OracleTimeSpan y) {}
	public static OracleBoolean LessThan(OracleTimeSpan x, OracleTimeSpan y) {}
	public static OracleBoolean LessThanOrEqual(OracleTimeSpan x, OracleTimeSpan y) {}
	public static OracleBoolean NotEquals(OracleTimeSpan x, OracleTimeSpan y) {}
	public static System.TimeSpan op_Explicit(OracleTimeSpan x) {}
	public static OracleTimeSpan op_Explicit(string x) {}
	public static OracleBoolean op_Equality(OracleTimeSpan x, OracleTimeSpan y) {}
	public static OracleBoolean op_GreaterThan(OracleTimeSpan x, OracleTimeSpan y) {}
	public static OracleBoolean op_GreaterThanOrEqual(OracleTimeSpan x, OracleTimeSpan y) {}
	public static OracleBoolean op_LessThan(OracleTimeSpan x, OracleTimeSpan y) {}
	public static OracleBoolean op_LessThanOrEqual(OracleTimeSpan x, OracleTimeSpan y) {}
	public static OracleBoolean op_Inequality(OracleTimeSpan x, OracleTimeSpan y) {}
	public Type GetType() {}

	// Fields
	public OracleTimeSpan MaxValue;
	public OracleTimeSpan MinValue;
	public OracleTimeSpan Null;

	// Properties
	public bool IsNull { get{} }
	public System.TimeSpan Value { get{} }
	public int Days { get{} }
	public int Hours { get{} }
	public int Minutes { get{} }
	public int Seconds { get{} }
	public int Milliseconds { get{} }
}

