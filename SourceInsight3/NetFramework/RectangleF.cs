public class RectangleF : System.ValueType
{

	// Constructors
	public RectangleF(float x, float y, float width, float height) {}
	public RectangleF(PointF location, SizeF size) {}

	// Methods
	public static RectangleF FromLTRB(float left, float top, float right, float bottom) {}
	public virtual bool Equals(object obj) {}
	public static bool op_Equality(RectangleF left, RectangleF right) {}
	public static bool op_Inequality(RectangleF left, RectangleF right) {}
	public bool Contains(float x, float y) {}
	public bool Contains(PointF pt) {}
	public bool Contains(RectangleF rect) {}
	public virtual int GetHashCode() {}
	public void Inflate(float x, float y) {}
	public void Inflate(SizeF size) {}
	public static RectangleF Inflate(RectangleF rect, float x, float y) {}
	public void Intersect(RectangleF rect) {}
	public static RectangleF Intersect(RectangleF a, RectangleF b) {}
	public bool IntersectsWith(RectangleF rect) {}
	public static RectangleF Union(RectangleF a, RectangleF b) {}
	public void Offset(PointF pos) {}
	public void Offset(float x, float y) {}
	public static RectangleF op_Implicit(Rectangle r) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public RectangleF Empty;

	// Properties
	public PointF Location { get{} set{} }
	public SizeF Size { get{} set{} }
	public float X { get{} set{} }
	public float Y { get{} set{} }
	public float Width { get{} set{} }
	public float Height { get{} set{} }
	public float Left { get{} }
	public float Top { get{} }
	public float Right { get{} }
	public float Bottom { get{} }
	public bool IsEmpty { get{} }
}

