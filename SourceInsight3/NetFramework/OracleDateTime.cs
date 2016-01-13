public class OracleDateTime : System.ValueType, System.IComparable, System.Data.SqlTypes.INullable
{

	// Constructors
	public OracleDateTime(System.DateTime dt) {}
	public OracleDateTime(long ticks) {}
	public OracleDateTime(int year, int month, int day) {}
	public OracleDateTime(int year, int month, int day, System.Globalization.Calendar calendar) {}
	public OracleDateTime(int year, int month, int day, int hour, int minute, int second) {}
	public OracleDateTime(int year, int month, int day, int hour, int minute, int second, System.Globalization.Calendar calendar) {}
	public OracleDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond) {}
	public OracleDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, System.Globalization.Calendar calendar) {}
	public OracleDateTime(OracleDateTime from) {}

	// Methods
	public virtual int CompareTo(object obj) {}
	public virtual bool Equals(object value) {}
	public virtual int GetHashCode() {}
	public static OracleDateTime Parse(string s) {}
	public virtual string ToString() {}
	public static OracleBoolean Equals(OracleDateTime x, OracleDateTime y) {}
	public static OracleBoolean GreaterThan(OracleDateTime x, OracleDateTime y) {}
	public static OracleBoolean GreaterThanOrEqual(OracleDateTime x, OracleDateTime y) {}
	public static OracleBoolean LessThan(OracleDateTime x, OracleDateTime y) {}
	public static OracleBoolean LessThanOrEqual(OracleDateTime x, OracleDateTime y) {}
	public static OracleBoolean NotEquals(OracleDateTime x, OracleDateTime y) {}
	public static System.DateTime op_Explicit(OracleDateTime x) {}
	public static OracleDateTime op_Explicit(string x) {}
	public static OracleBoolean op_Equality(OracleDateTime x, OracleDateTime y) {}
	public static OracleBoolean op_GreaterThan(OracleDateTime x, OracleDateTime y) {}
	public static OracleBoolean op_GreaterThanOrEqual(OracleDateTime x, OracleDateTime y) {}
	public static OracleBoolean op_LessThan(OracleDateTime x, OracleDateTime y) {}
	public static OracleBoolean op_LessThanOrEqual(OracleDateTime x, OracleDateTime y) {}
	public static OracleBoolean op_Inequality(OracleDateTime x, OracleDateTime y) {}
	public Type GetType() {}

	// Fields
	public OracleDateTime MaxValue;
	public OracleDateTime MinValue;
	public OracleDateTime Null;

	// Properties
	public bool IsNull { get{} }
	public System.DateTime Value { get{} }
	public int Year { get{} }
	public int Month { get{} }
	public int Day { get{} }
	public int Hour { get{} }
	public int Minute { get{} }
	public int Second { get{} }
	public int Millisecond { get{} }
}

