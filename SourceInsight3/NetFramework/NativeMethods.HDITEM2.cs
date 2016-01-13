public class HDITEM2
{

	// Constructors
	public HDITEM2() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int mask;
	public int cxy;
	public System.IntPtr pszText_notUsed;
	public System.IntPtr hbm;
	public int cchTextMax;
	public int fmt;
	public System.IntPtr lParam;
	public int iImage;
	public int iOrder;
	public int type;
	public System.IntPtr pvFilter;
}

