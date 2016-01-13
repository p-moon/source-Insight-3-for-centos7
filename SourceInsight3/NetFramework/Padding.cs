public class Padding : System.ValueType
{

	// Constructors
	public Padding(int all) {}
	public Padding(int left, int top, int right, int bottom) {}

	// Methods
	public static Padding Add(Padding p1, Padding p2) {}
	public static Padding Subtract(Padding p1, Padding p2) {}
	public virtual bool Equals(object other) {}
	public static Padding op_Addition(Padding p1, Padding p2) {}
	public static Padding op_Subtraction(Padding p1, Padding p2) {}
	public static bool op_Equality(Padding p1, Padding p2) {}
	public static bool op_Inequality(Padding p1, Padding p2) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public Padding Empty;

	// Properties
	public int All { get{} set{} }
	public int Bottom { get{} set{} }
	public int Left { get{} set{} }
	public int Right { get{} set{} }
	public int Top { get{} set{} }
	public int Horizontal { get{} }
	public int Vertical { get{} }
	public System.Drawing.Size Size { get{} }
}

