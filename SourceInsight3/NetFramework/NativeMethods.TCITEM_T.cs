public class TCITEM_T
{

	// Constructors
	public TCITEM_T() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int mask;
	public int dwState;
	public int dwStateMask;
	public string pszText;
	public int cchTextMax;
	public int iImage;
	public System.IntPtr lParam;
}

