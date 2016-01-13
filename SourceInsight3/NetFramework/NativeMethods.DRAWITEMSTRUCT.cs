public class DRAWITEMSTRUCT
{

	// Constructors
	public DRAWITEMSTRUCT() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int CtlType;
	public int CtlID;
	public int itemID;
	public int itemAction;
	public int itemState;
	public System.IntPtr hwndItem;
	public System.IntPtr hDC;
	public RECT rcItem;
	public System.IntPtr itemData;
}

