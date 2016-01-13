public class LVITEM : System.ValueType
{

	// Methods
	public void Reset() {}
	public virtual string ToString() {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public Type GetType() {}

	// Fields
	public int mask;
	public int iItem;
	public int iSubItem;
	public int state;
	public int stateMask;
	public string pszText;
	public int cchTextMax;
	public int iImage;
	public System.IntPtr lParam;
	public int iIndent;
	public int iGroupId;
	public int cColumns;
	public System.IntPtr puColumns;
}

