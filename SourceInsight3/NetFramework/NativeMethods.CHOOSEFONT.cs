public class CHOOSEFONT
{

	// Constructors
	public CHOOSEFONT() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int lStructSize;
	public System.IntPtr hwndOwner;
	public System.IntPtr hDC;
	public System.IntPtr lpLogFont;
	public int iPointSize;
	public int Flags;
	public int rgbColors;
	public System.IntPtr lCustData;
	public WndProc lpfnHook;
	public string lpTemplateName;
	public System.IntPtr hInstance;
	public string lpszStyle;
	public short nFontType;
	public short ___MISSING_ALIGNMENT__;
	public int nSizeMin;
	public int nSizeMax;
}

