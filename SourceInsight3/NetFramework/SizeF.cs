public class SizeF : System.ValueType
{

	// Constructors
	public SizeF(SizeF size) {}
	public SizeF(PointF pt) {}
	public SizeF(float width, float height) {}

	// Methods
	public static SizeF op_Addition(SizeF sz1, SizeF sz2) {}
	public static SizeF op_Subtraction(SizeF sz1, SizeF sz2) {}
	public static bool op_Equality(SizeF sz1, SizeF sz2) {}
	public static bool op_Inequality(SizeF sz1, SizeF sz2) {}
	public static PointF op_Explicit(SizeF size) {}
	public static SizeF Add(SizeF sz1, SizeF sz2) {}
	public static SizeF Subtract(SizeF sz1, SizeF sz2) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public PointF ToPointF() {}
	public Size ToSize() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public SizeF Empty;

	// Properties
	public bool IsEmpty { get{} }
	public float Width { get{} set{} }
	public float Height { get{} set{} }
}

