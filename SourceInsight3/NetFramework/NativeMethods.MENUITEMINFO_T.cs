public class MENUITEMINFO_T
{

	// Constructors
	public MENUITEMINFO_T() {}

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
	public string dwTypeData;
	public int cch;
}

