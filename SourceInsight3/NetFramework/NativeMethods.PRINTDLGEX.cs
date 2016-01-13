public class PRINTDLGEX
{

	// Constructors
	public PRINTDLGEX() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int lStructSize;
	public System.IntPtr hwndOwner;
	public System.IntPtr hDevMode;
	public System.IntPtr hDevNames;
	public System.IntPtr hDC;
	public int Flags;
	public int Flags2;
	public int ExclusionFlags;
	public int nPageRanges;
	public int nMaxPageRanges;
	public System.IntPtr pageRanges;
	public int nMinPage;
	public int nMaxPage;
	public int nCopies;
	public System.IntPtr hInstance;
	public string lpPrintTemplateName;
	public WndProc lpCallback;
	public int nPropertyPages;
	public System.IntPtr lphPropertyPages;
	public int nStartPage;
	public int dwResultAction;
}

