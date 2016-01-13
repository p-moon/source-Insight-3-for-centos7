public class LVCOLUMN_T
{

	// Constructors
	public LVCOLUMN_T() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int mask;
	public int fmt;
	public int cx;
	public string pszText;
	public int cchTextMax;
	public int iSubItem;
	public int iImage;
	public int iOrder;
}

