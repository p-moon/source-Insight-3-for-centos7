public class Screen
{

	// Methods
	public virtual bool Equals(object obj) {}
	public static Screen FromPoint(System.Drawing.Point point) {}
	public static Screen FromRectangle(System.Drawing.Rectangle rect) {}
	public static Screen FromControl(Control control) {}
	public static Screen FromHandle(System.IntPtr hwnd) {}
	public static System.Drawing.Rectangle GetWorkingArea(System.Drawing.Point pt) {}
	public static System.Drawing.Rectangle GetWorkingArea(System.Drawing.Rectangle rect) {}
	public static System.Drawing.Rectangle GetWorkingArea(Control ctl) {}
	public static System.Drawing.Rectangle GetBounds(System.Drawing.Point pt) {}
	public static System.Drawing.Rectangle GetBounds(System.Drawing.Rectangle rect) {}
	public static System.Drawing.Rectangle GetBounds(Control ctl) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public Screen[] AllScreens { get{} }
	public int BitsPerPixel { get{} }
	public System.Drawing.Rectangle Bounds { get{} }
	public string DeviceName { get{} }
	public bool Primary { get{} }
	public Screen PrimaryScreen { get{} }
	public System.Drawing.Rectangle WorkingArea { get{} }
}

