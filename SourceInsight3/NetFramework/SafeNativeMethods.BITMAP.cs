public class BITMAP
{

	// Constructors
	public BITMAP() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int bmType;
	public int bmWidth;
	public int bmHeight;
	public int bmWidthBytes;
	public short bmPlanes;
	public short bmBitsPixel;
	public System.IntPtr bmBits;
}

