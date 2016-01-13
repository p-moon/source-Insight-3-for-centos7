public class MENUITEMINFO_T_RW
{

	// Constructors
	public MENUITEMINFO_T_RW() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int cbSize;
	public int fMask;
	public int fType;
	public int fState;
	public int wID;
	public System.IntPtr hSubMenu;
	public System.IntPtr hbmpChecked;
	public System.IntPtr hbmpUnchecked;
	public System.IntPtr dwItemData;
	public System.IntPtr dwTypeData;
	public int cch;
	public System.IntPtr hbmpItem;
}

