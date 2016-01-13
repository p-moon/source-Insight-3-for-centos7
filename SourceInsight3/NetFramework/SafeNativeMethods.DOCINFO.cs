public class DOCINFO
{

	// Constructors
	public DOCINFO() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int cbSize;
	public string lpszDocName;
	public string lpszOutput;
	public string lpszDatatype;
	public int fwType;
}

