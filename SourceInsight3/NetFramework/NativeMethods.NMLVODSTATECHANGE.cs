public class NMLVODSTATECHANGE
{

	// Constructors
	public NMLVODSTATECHANGE() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public NMHDR hdr;
	public int iFrom;
	public int iTo;
	public int uNewState;
	public int uOldState;
}

