public class LVTILEVIEWINFO
{

	// Constructors
	public LVTILEVIEWINFO() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public uint cbSize;
	public int dwMask;
	public int dwFlags;
	public SIZE sizeTile;
	public int cLines;
	public RECT rcLabelMargin;
}

