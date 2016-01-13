public class MEASUREITEMSTRUCT
{

	// Constructors
	public MEASUREITEMSTRUCT() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int CtlType;
	public int CtlID;
	public int itemID;
	public int itemWidth;
	public int itemHeight;
	public System.IntPtr itemData;
}

