public class ENLINK
{

	// Constructors
	public ENLINK() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public NMHDR nmhdr;
	public int msg;
	public System.IntPtr wParam;
	public System.IntPtr lParam;
	public CHARRANGE charrange;
}

