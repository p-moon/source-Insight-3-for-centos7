public class WNDCLASS_I
{

	// Constructors
	public WNDCLASS_I() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int style;
	public System.IntPtr lpfnWndProc;
	public int cbClsExtra;
	public int cbWndExtra;
	public System.IntPtr hInstance;
	public System.IntPtr hIcon;
	public System.IntPtr hCursor;
	public System.IntPtr hbrBackground;
	public System.IntPtr lpszMenuName;
	public System.IntPtr lpszClassName;
}

