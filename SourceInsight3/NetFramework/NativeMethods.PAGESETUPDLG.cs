public class PAGESETUPDLG
{

	// Constructors
	public PAGESETUPDLG() {}

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
	public int Flags;
	public int paperSizeX;
	public int paperSizeY;
	public int minMarginLeft;
	public int minMarginTop;
	public int minMarginRight;
	public int minMarginBottom;
	public int marginLeft;
	public int marginTop;
	public int marginRight;
	public int marginBottom;
	public System.IntPtr hInstance;
	public System.IntPtr lCustData;
	public WndProc lpfnPageSetupHook;
	public WndProc lpfnPagePaintHook;
	public string lpPageSetupTemplateName;
	public System.IntPtr hPageSetupTemplate;
}

