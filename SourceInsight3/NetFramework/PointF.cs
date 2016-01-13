public class PointF : System.ValueType
{

	// Constructors
	public PointF(float x, float y) {}

	// Methods
	public static PointF op_Addition(PointF pt, Size sz) {}
	public static PointF op_Subtraction(PointF pt, Size sz) {}
	public static PointF op_Addition(PointF pt, SizeF sz) {}
	public static PointF op_Subtraction(PointF pt, SizeF sz) {}
	public static bool op_Equality(PointF left, PointF right) {}
	public static bool op_Inequality(PointF left, PointF right) {}
	public static PointF Add(PointF pt, Size sz) {}
	public static PointF Subtract(PointF pt, Size sz) {}
	public static PointF Add(PointF pt, SizeF sz) {}
	public static PointF Subtract(PointF pt, SizeF sz) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public PointF Empty;

	// Properties
	public bool IsEmpty { get{} }
	public float X { get{} set{} }
	public float Y { get{} set{} }
}

