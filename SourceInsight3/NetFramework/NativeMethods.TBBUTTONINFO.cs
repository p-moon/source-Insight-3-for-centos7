public class TBBUTTONINFO : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public int cbSize;
	public int dwMask;
	public int idCommand;
	public int iImage;
	public byte fsState;
	public byte fsStyle;
	public short cx;
	public System.IntPtr lParam;
	public System.IntPtr pszText;
	public int cchTest;
}

