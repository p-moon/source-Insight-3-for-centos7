public class WINDOWPLACEMENT : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public int length;
	public int flags;
	public int showCmd;
	public int ptMinPosition_x;
	public int ptMinPosition_y;
	public int ptMaxPosition_x;
	public int ptMaxPosition_y;
	public int rcNormalPosition_left;
	public int rcNormalPosition_top;
	public int rcNormalPosition_right;
	public int rcNormalPosition_bottom;
}

