public class IMAGEINFO
{

	// Constructors
	public IMAGEINFO() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public System.IntPtr hbmImage;
	public System.IntPtr hbmMask;
	public int Unused1;
	public int Unused2;
	public int rcImage_left;
	public int rcImage_top;
	public int rcImage_right;
	public int rcImage_bottom;
}

