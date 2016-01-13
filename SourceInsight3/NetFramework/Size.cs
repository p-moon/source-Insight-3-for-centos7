public class Size : System.ValueType
{

	// Constructors
	public Size(int width, int height) {}
	public Size(Point pt) {}

	// Methods
	public static SizeF op_Implicit(Size p) {}
	public static Size op_Addition(Size sz1, Size sz2) {}
	public static Size op_Subtraction(Size sz1, Size sz2) {}
	public static bool op_Equality(Size sz1, Size sz2) {}
	public static bool op_Inequality(Size sz1, Size sz2) {}
	public static Point op_Explicit(Size size) {}
	public static Size Add(Size sz1, Size sz2) {}
	public static Size Ceiling(SizeF value) {}
	public static Size Subtract(Size sz1, Size sz2) {}
	public static Size Truncate(SizeF value) {}
	public static Size Round(SizeF value) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public Size Empty;

	// Properties
	public bool IsEmpty { get{} }
	public int Width { get{} set{} }
	public int Height { get{} set{} }
}

