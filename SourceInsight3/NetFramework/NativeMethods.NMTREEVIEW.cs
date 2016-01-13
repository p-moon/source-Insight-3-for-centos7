public class NMTREEVIEW : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public NMHDR nmhdr;
	public int action;
	public TV_ITEM itemOld;
	public TV_ITEM itemNew;
	public int ptDrag_X;
	public int ptDrag_Y;
}

