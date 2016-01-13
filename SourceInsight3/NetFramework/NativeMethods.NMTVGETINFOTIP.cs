public class NMTVGETINFOTIP : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public NMHDR nmhdr;
	public string pszText;
	public int cchTextMax;
	public System.IntPtr item;
	public System.IntPtr lParam;
}

