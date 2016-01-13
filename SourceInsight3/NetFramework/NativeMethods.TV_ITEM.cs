public class TV_ITEM : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public int mask;
	public System.IntPtr hItem;
	public int state;
	public int stateMask;
	public System.IntPtr pszText;
	public int cchTextMax;
	public int iImage;
	public int iSelectedImage;
	public int cChildren;
	public System.IntPtr lParam;
}

