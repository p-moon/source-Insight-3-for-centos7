public class NMLVGETINFOTIP
{

	// Constructors
	public NMLVGETINFOTIP() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public NMHDR nmhdr;
	public int flags;
	public System.IntPtr lpszText;
	public int cchTextMax;
	public int item;
	public int subItem;
	public System.IntPtr lParam;
}

