public class ICONINFO
{

	// Constructors
	public ICONINFO() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int fIcon;
	public int xHotspot;
	public int yHotspot;
	public System.IntPtr hbmMask;
	public System.IntPtr hbmColor;
}

