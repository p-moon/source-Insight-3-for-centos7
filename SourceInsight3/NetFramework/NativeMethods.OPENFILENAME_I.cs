public class OPENFILENAME_I
{

	// Constructors
	public OPENFILENAME_I() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int lStructSize;
	public System.IntPtr hwndOwner;
	public System.IntPtr hInstance;
	public string lpstrFilter;
	public System.IntPtr lpstrCustomFilter;
	public int nMaxCustFilter;
	public int nFilterIndex;
	public System.IntPtr lpstrFile;
	public int nMaxFile;
	public System.IntPtr lpstrFileTitle;
	public int nMaxFileTitle;
	public string lpstrInitialDir;
	public string lpstrTitle;
	public int Flags;
	public short nFileOffset;
	public short nFileExtension;
	public string lpstrDefExt;
	public System.IntPtr lCustData;
	public WndProc lpfnHook;
	public string lpTemplateName;
	public System.IntPtr pvReserved;
	public int dwReserved;
	public int FlagsEx;
}

