public class SCOPEDATAITEM : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public int mask;
	public System.IntPtr displayname;
	public int nImage;
	public int nOpenImage;
	public int nState;
	public int cChildren;
	public int lParam;
	public int relativeID;
	public int ID;
}

