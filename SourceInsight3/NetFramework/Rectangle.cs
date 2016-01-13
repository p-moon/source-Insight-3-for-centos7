public class Rectangle : System.ValueType
{

	// Constructors
	public Rectangle(int x, int y, int width, int height) {}
	public Rectangle(Point location, Size size) {}

	// Methods
	public static Rectangle FromLTRB(int left, int top, int right, int bottom) {}
	public virtual bool Equals(object obj) {}
	public static bool op_Equality(Rectangle left, Rectangle right) {}
	public static bool op_Inequality(Rectangle left, Rectangle right) {}
	public static Rectangle Ceiling(RectangleF value) {}
	public static Rectangle Truncate(RectangleF value) {}
	public static Rectangle Round(RectangleF value) {}
	public bool Contains(int x, int y) {}
	public bool Contains(Point pt) {}
	public bool Contains(Rectangle rect) {}
	public virtual int GetHashCode() {}
	public void Inflate(int width, int height) {}
	public void Inflate(Size size) {}
	public static Rectangle Inflate(Rectangle rect, int x, int y) {}
	public void Intersect(Rectangle rect) {}
	public static Rectangle Intersect(Rectangle a, Rectangle b) {}
	public bool IntersectsWith(Rectangle rect) {}
	public static Rectangle Union(Rectangle a, Rectangle b) {}
	public void Offset(Point pos) {}
	public void Offset(int x, int y) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public Rectangle Empty;

	// Properties
	public Point Location { get{} set{} }
	public Size Size { get{} set{} }
	public int X { get{} set{} }
	public int Y { get{} set{} }
	public int Width { get{} set{} }
	public int Height { get{} set{} }
	public int Left { get{} }
	public int Top { get{} }
	public int Right { get{} }
	public int Bottom { get{} }
	public bool IsEmpty { get{} }
}

