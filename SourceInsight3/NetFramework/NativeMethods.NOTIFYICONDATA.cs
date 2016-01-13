public class NOTIFYICONDATA
{

	// Constructors
	public NOTIFYICONDATA() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int cbSize;
	public System.IntPtr hWnd;
	public int uID;
	public int uFlags;
	public int uCallbackMessage;
	public System.IntPtr hIcon;
	public string szTip;
	public int dwState;
	public int dwStateMask;
	public string szInfo;
	public int uTimeoutOrVersion;
	public string szInfoTitle;
	public int dwInfoFlags;
}

