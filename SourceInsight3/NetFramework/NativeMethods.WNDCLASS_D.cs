public class WNDCLASS_D
{

	// Constructors
	public WNDCLASS_D() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int style;
	public WndProc lpfnWndProc;
	public int cbClsExtra;
	public int cbWndExtra;
	public System.IntPtr hInstance;
	public System.IntPtr hIcon;
	public System.IntPtr hCursor;
	public System.IntPtr hbrBackground;
	public string lpszMenuName;
	public string lpszClassName;
}

