public class LVCOLUMN
{

	// Constructors
	public LVCOLUMN() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int mask;
	public int fmt;
	public int cx;
	public System.IntPtr pszText;
	public int cchTextMax;
	public int iSubItem;
	public int iImage;
	public int iOrder;
}

