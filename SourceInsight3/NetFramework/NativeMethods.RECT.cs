public class RECT : System.ValueType
{

	// Constructors
	public RECT(int left, int top, int right, int bottom) {}
	public RECT(System.Drawing.Rectangle r) {}

	// Methods
	public static RECT FromXYWH(int x, int y, int width, int height) {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public int left;
	public int top;
	public int right;
	public int bottom;

	// Properties
	public System.Drawing.Size Size { get{} }
}

