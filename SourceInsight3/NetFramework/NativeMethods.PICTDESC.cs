public class PICTDESC
{

	// Constructors
	public PICTDESC() {}

	// Methods
	public static PICTDESC CreateBitmapPICTDESC(System.IntPtr hbitmap, System.IntPtr hpal) {}
	public static PICTDESC CreateIconPICTDESC(System.IntPtr hicon) {}
	public virtual System.IntPtr GetHandle() {}
	public virtual System.IntPtr GetHPal() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int picType;
}

