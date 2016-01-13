public class NMLVFINDITEM : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public NMHDR hdr;
	public int iStart;
	public LVFINDINFO lvfi;
}

