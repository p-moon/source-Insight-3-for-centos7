public class PARAFORMAT
{

	// Constructors
	public PARAFORMAT() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int cbSize;
	public int dwMask;
	public short wNumbering;
	public short wReserved;
	public int dxStartIndent;
	public int dxRightIndent;
	public int dxOffset;
	public short wAlignment;
	public short cTabCount;
	public int[] rgxTabs;
}

