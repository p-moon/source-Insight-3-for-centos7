public interface ISimpleFrameSite
{

	// Methods
	public abstract virtual int PreMessageFilter(System.IntPtr hwnd, int msg, System.IntPtr wp, System.IntPtr lpout , System.IntPtr& plResultout , System.Int32& pdwCookie) {}
	public abstract virtual int PostMessageFilter(System.IntPtr hwnd, int msg, System.IntPtr wp, System.IntPtr lpout , System.IntPtr& plResult, int dwCookie) {}
}

