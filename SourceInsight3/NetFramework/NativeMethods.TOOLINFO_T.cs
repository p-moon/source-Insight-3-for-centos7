public class TOOLINFO_T
{

	// Constructors
	public TOOLINFO_T() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int cbSize;
	public int uFlags;
	public System.IntPtr hwnd;
	public System.IntPtr uId;
	public RECT rect;
	public System.IntPtr hinst;
	public string lpszText;
	public System.IntPtr lParam;
}

