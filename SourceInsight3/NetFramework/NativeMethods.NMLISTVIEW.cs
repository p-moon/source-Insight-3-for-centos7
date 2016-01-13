public class NMLISTVIEW : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public NMHDR hdr;
	public int iItem;
	public int iSubItem;
	public int uNewState;
	public int uOldState;
	public int uChanged;
	public System.IntPtr lParam;
}

