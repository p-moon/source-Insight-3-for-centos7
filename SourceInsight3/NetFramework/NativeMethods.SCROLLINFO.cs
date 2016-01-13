public class SCROLLINFO
{

	// Constructors
	public SCROLLINFO() {}
	public SCROLLINFO(int mask, int min, int max, int page, int pos) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int cbSize;
	public int fMask;
	public int nMin;
	public int nMax;
	public int nPage;
	public int nPos;
	public int nTrackPos;
}

