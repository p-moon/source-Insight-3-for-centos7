public class NMLVCUSTOMDRAW : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public NMCUSTOMDRAW nmcd;
	public int clrText;
	public int clrTextBk;
	public int iSubItem;
	public int dwItemType;
	public int clrFace;
	public int iIconEffect;
	public int iIconPhase;
	public int iPartId;
	public int iStateId;
	public RECT rcText;
	public uint uAlign;
}

