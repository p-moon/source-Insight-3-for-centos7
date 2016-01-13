public class PRINTDLG
{

	// Constructors
	public PRINTDLG() {}

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
	public short nFromPage;
	public short nToPage;
	public short nMinPage;
	public short nMaxPage;
	public short nCopies;
	public System.IntPtr hInstance;
	public System.IntPtr lCustData;
	public WndProc lpfnPrintHook;
	public WndProc lpfnSetupHook;
	public string lpPrintTemplateName;
	public string lpSetupTemplateName;
	public System.IntPtr hPrintTemplate;
	public System.IntPtr hSetupTemplate;
}

