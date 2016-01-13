public class NMTOOLBAR : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public NMHDR hdr;
	public int iItem;
	public TBBUTTON tbButton;
	public int cchText;
	public System.IntPtr pszText;
}

