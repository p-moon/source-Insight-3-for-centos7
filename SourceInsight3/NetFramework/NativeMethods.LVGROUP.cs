public class LVGROUP
{

	// Constructors
	public LVGROUP() {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public uint cbSize;
	public uint mask;
	public System.IntPtr pszHeader;
	public int cchHeader;
	public System.IntPtr pszFooter;
	public int cchFooter;
	public int iGroupId;
	public uint stateMask;
	public uint state;
	public uint uAlign;
}

