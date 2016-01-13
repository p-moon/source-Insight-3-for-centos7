public class TV_INSERTSTRUCT : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public System.IntPtr hParent;
	public System.IntPtr hInsertAfter;
	public int item_mask;
	public System.IntPtr item_hItem;
	public int item_state;
	public int item_stateMask;
	public System.IntPtr item_pszText;
	public int item_cchTextMax;
	public int item_iImage;
	public int item_iSelectedImage;
	public int item_cChildren;
	public System.IntPtr item_lParam;
	public int item_iIntegral;
}

