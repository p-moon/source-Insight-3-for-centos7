public class MINMAXINFO
{

	// Constructors
	public MINMAXINFO() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public POINT ptReserved;
	public POINT ptMaxSize;
	public POINT ptMaxPosition;
	public POINT ptMinTrackSize;
	public POINT ptMaxTrackSize;
}

