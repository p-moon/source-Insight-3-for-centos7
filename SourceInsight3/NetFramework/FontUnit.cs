public class FontUnit : System.ValueType
{

	// Constructors
	public FontUnit(FontSize type) {}
	public FontUnit(Unit value) {}
	public FontUnit(int value) {}
	public FontUnit(double value) {}
	public FontUnit(double value, UnitType type) {}
	public FontUnit(string value) {}
	public FontUnit(string value, System.Globalization.CultureInfo culture) {}

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public static bool op_Equality(FontUnit left, FontUnit right) {}
	public static bool op_Inequality(FontUnit left, FontUnit right) {}
	public static FontUnit Parse(string s) {}
	public static FontUnit Parse(string s, System.Globalization.CultureInfo culture) {}
	public static FontUnit Point(int n) {}
	public virtual string ToString() {}
	public string ToString(System.Globalization.CultureInfo culture) {}
	public string ToString(System.IFormatProvider formatProvider) {}
	public static FontUnit op_Implicit(int n) {}
	public Type GetType() {}

	// Fields
	public FontUnit Empty;
	public FontUnit Smaller;
	public FontUnit Larger;
	public FontUnit XXSmall;
	public FontUnit XSmall;
	public FontUnit Small;
	public FontUnit Medium;
	public FontUnit Large;
	public FontUnit XLarge;
	public FontUnit XXLarge;

	// Properties
	public bool IsEmpty { get{} }
	public FontSize Type { get{} }
	public Unit Unit { get{} }
}

