public class OFNOTIFY
{

	// Constructors
	public OFNOTIFY() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public System.IntPtr hdr_hwndFrom;
	public System.IntPtr hdr_idFrom;
	public int hdr_code;
	public System.IntPtr lpOFN;
	public System.IntPtr pszFile;
}

