public class OracleNumber : System.ValueType, System.IComparable, System.Data.SqlTypes.INullable
{

	// Constructors
	public OracleNumber(decimal decValue) {}
	public OracleNumber(double dblValue) {}
	public OracleNumber(int intValue) {}
	public OracleNumber(long longValue) {}
	public OracleNumber(OracleNumber from) {}

	// Methods
	public virtual int CompareTo(object obj) {}
	public virtual bool Equals(object value) {}
	public virtual int GetHashCode() {}
	public static OracleNumber Parse(string s) {}
	public virtual string ToString() {}
	public static OracleBoolean op_Equality(OracleNumber x, OracleNumber y) {}
	public static OracleBoolean op_GreaterThan(OracleNumber x, OracleNumber y) {}
	public static OracleBoolean op_GreaterThanOrEqual(OracleNumber x, OracleNumber y) {}
	public static OracleBoolean op_LessThan(OracleNumber x, OracleNumber y) {}
	public static OracleBoolean op_LessThanOrEqual(OracleNumber x, OracleNumber y) {}
	public static OracleBoolean op_Inequality(OracleNumber x, OracleNumber y) {}
	public static OracleNumber op_UnaryNegation(OracleNumber x) {}
	public static OracleNumber op_Addition(OracleNumber x, OracleNumber y) {}
	public static OracleNumber op_Subtraction(OracleNumber x, OracleNumber y) {}
	public static OracleNumber op_Multiply(OracleNumber x, OracleNumber y) {}
	public static OracleNumber op_Division(OracleNumber x, OracleNumber y) {}
	public static OracleNumber op_Modulus(OracleNumber x, OracleNumber y) {}
	public static decimal op_Explicit(OracleNumber x) {}
	public static double op_Explicit(OracleNumber x) {}
	public static int op_Explicit(OracleNumber x) {}
	public static long op_Explicit(OracleNumber x) {}
	public static OracleNumber op_Explicit(decimal x) {}
	public static OracleNumber op_Explicit(double x) {}
	public static OracleNumber op_Explicit(int x) {}
	public static OracleNumber op_Explicit(long x) {}
	public static OracleNumber op_Explicit(string x) {}
	public static OracleNumber Abs(OracleNumber n) {}
	public static OracleNumber Acos(OracleNumber n) {}
	public static OracleNumber Add(OracleNumber x, OracleNumber y) {}
	public static OracleNumber Asin(OracleNumber n) {}
	public static OracleNumber Atan(OracleNumber n) {}
	public static OracleNumber Atan2(OracleNumber y, OracleNumber x) {}
	public static OracleNumber Ceiling(OracleNumber n) {}
	public static OracleNumber Cos(OracleNumber n) {}
	public static OracleNumber Cosh(OracleNumber n) {}
	public static OracleNumber Divide(OracleNumber x, OracleNumber y) {}
	public static OracleBoolean Equals(OracleNumber x, OracleNumber y) {}
	public static OracleNumber Exp(OracleNumber p) {}
	public static OracleNumber Floor(OracleNumber n) {}
	public static OracleBoolean GreaterThan(OracleNumber x, OracleNumber y) {}
	public static OracleBoolean GreaterThanOrEqual(OracleNumber x, OracleNumber y) {}
	public static OracleBoolean LessThan(OracleNumber x, OracleNumber y) {}
	public static OracleBoolean LessThanOrEqual(OracleNumber x, OracleNumber y) {}
	public static OracleNumber Log(OracleNumber n) {}
	public static OracleNumber Log(OracleNumber n, int newBase) {}
	public static OracleNumber Log(OracleNumber n, OracleNumber newBase) {}
	public static OracleNumber Log10(OracleNumber n) {}
	public static OracleNumber Max(OracleNumber x, OracleNumber y) {}
	public static OracleNumber Min(OracleNumber x, OracleNumber y) {}
	public static OracleNumber Modulo(OracleNumber x, OracleNumber y) {}
	public static OracleNumber Multiply(OracleNumber x, OracleNumber y) {}
	public static OracleNumber Negate(OracleNumber x) {}
	public static OracleBoolean NotEquals(OracleNumber x, OracleNumber y) {}
	public static OracleNumber Pow(OracleNumber x, int y) {}
	public static OracleNumber Pow(OracleNumber x, OracleNumber y) {}
	public static OracleNumber Round(OracleNumber n, int position) {}
	public static OracleNumber Shift(OracleNumber n, int digits) {}
	public static OracleNumber Sign(OracleNumber n) {}
	public static OracleNumber Sin(OracleNumber n) {}
	public static OracleNumber Sinh(OracleNumber n) {}
	public static OracleNumber Sqrt(OracleNumber n) {}
	public static OracleNumber Subtract(OracleNumber x, OracleNumber y) {}
	public static OracleNumber Tan(OracleNumber n) {}
	public static OracleNumber Tanh(OracleNumber n) {}
	public static OracleNumber Truncate(OracleNumber n, int position) {}
	public Type GetType() {}

	// Fields
	public OracleNumber E;
	public int MaxPrecision;
	public int MaxScale;
	public int MinScale;
	public OracleNumber MaxValue;
	public OracleNumber MinValue;
	public OracleNumber MinusOne;
	public OracleNumber Null;
	public OracleNumber One;
	public OracleNumber PI;
	public OracleNumber Zero;

	// Properties
	public bool IsNull { get{} }
	public decimal Value { get{} }
}

