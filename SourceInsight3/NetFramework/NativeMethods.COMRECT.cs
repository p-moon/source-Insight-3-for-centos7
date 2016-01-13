public class COMRECT
{

	// Constructors
	public COMRECT() {}
	public COMRECT(System.Drawing.Rectangle r) {}
	public COMRECT(int left, int top, int right, int bottom) {}

	// Methods
	public static COMRECT FromXYWH(int x, int y, int width, int height) {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int left;
	public int top;
	public int right;
	public int bottom;
}

