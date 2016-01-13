public class Point : System.ValueType
{

	// Constructors
	public Point(int x, int y) {}
	public Point(Size sz) {}
	public Point(int dw) {}

	// Methods
	public static PointF op_Implicit(Point p) {}
	public static Size op_Explicit(Point p) {}
	public static Point op_Addition(Point pt, Size sz) {}
	public static Point op_Subtraction(Point pt, Size sz) {}
	public static bool op_Equality(Point left, Point right) {}
	public static bool op_Inequality(Point left, Point right) {}
	public static Point Add(Point pt, Size sz) {}
	public static Point Subtract(Point pt, Size sz) {}
	public static Point Ceiling(PointF value) {}
	public static Point Truncate(PointF value) {}
	public static Point Round(PointF value) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public void Offset(int dx, int dy) {}
	public void Offset(Point p) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public Point Empty;

	// Properties
	public bool IsEmpty { get{} }
	public int X { get{} set{} }
	public int Y { get{} set{} }
}

