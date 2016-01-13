public class Unit : System.ValueType
{

	// Constructors
	public Unit(int value) {}
	public Unit(double value) {}
	public Unit(double value, UnitType type) {}
	public Unit(string value) {}
	public Unit(string value, System.Globalization.CultureInfo culture) {}

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public static bool op_Equality(Unit left, Unit right) {}
	public static bool op_Inequality(Unit left, Unit right) {}
	public static Unit Parse(string s) {}
	public static Unit Parse(string s, System.Globalization.CultureInfo culture) {}
	public static Unit Percentage(double n) {}
	public static Unit Pixel(int n) {}
	public static Unit Point(int n) {}
	public virtual string ToString() {}
	public string ToString(System.Globalization.CultureInfo culture) {}
	public string ToString(System.IFormatProvider formatProvider) {}
	public static Unit op_Implicit(int n) {}
	public Type GetType() {}

	// Fields
	public Unit Empty;

	// Properties
	public bool IsEmpty { get{} }
	public UnitType Type { get{} }
	public double Value { get{} }
}

