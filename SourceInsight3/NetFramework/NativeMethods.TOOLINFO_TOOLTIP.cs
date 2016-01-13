public class TOOLINFO_TOOLTIP
{

	// Constructors
	public TOOLINFO_TOOLTIP() {}

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
	public System.IntPtr lpszText;
	public System.IntPtr lParam;
}

