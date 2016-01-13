public class BROWSEINFO
{

	// Constructors
	public BROWSEINFO() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public System.IntPtr hwndOwner;
	public System.IntPtr pidlRoot;
	public System.IntPtr pszDisplayName;
	public string lpszTitle;
	public int ulFlags;
	public BrowseCallbackProc lpfn;
	public System.IntPtr lParam;
	public int iImage;
}

