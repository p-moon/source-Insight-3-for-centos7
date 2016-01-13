public class TPMPARAMS
{

	// Constructors
	public TPMPARAMS() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int cbSize;
	public int rcExclude_left;
	public int rcExclude_top;
	public int rcExclude_right;
	public int rcExclude_bottom;
}

