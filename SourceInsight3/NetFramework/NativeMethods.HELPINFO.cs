public class HELPINFO
{

	// Constructors
	public HELPINFO() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int cbSize;
	public int iContextType;
	public int iCtrlId;
	public System.IntPtr hItemHandle;
	public int dwContextId;
	public POINT MousePos;
}

