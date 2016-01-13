public class Shell32
{

	// Constructors
	public Shell32() {}

	// Methods
	public static int SHGetSpecialFolderLocation(System.IntPtr hwnd, int csidl, System.IntPtr& ppidl) {}
	public static bool SHGetPathFromIDList(System.IntPtr pidl, System.IntPtr pszPath) {}
	public static System.IntPtr SHBrowseForFolder(BROWSEINFO lpbi) {}
	public static int SHGetMalloc(out IMalloc[] ppMalloc) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

