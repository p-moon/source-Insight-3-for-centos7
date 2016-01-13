public class NMDAYSTATE
{

	// Constructors
	public NMDAYSTATE() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public NMHDR nmhdr;
	public SYSTEMTIME stStart;
	public int cDayState;
	public System.IntPtr prgDayState;
}

