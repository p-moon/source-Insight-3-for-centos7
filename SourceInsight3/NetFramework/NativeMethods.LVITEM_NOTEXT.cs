public class LVITEM_NOTEXT : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public int mask;
	public int iItem;
	public int iSubItem;
	public int state;
	public int stateMask;
	public System.IntPtr pszText;
	public int cchTextMax;
	public int iImage;
	public System.IntPtr lParam;
	public int iIndent;
}

