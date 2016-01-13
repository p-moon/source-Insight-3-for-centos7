public class BITMAPINFO_FLAT : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public int bmiHeader_biSize;
	public int bmiHeader_biWidth;
	public int bmiHeader_biHeight;
	public short bmiHeader_biPlanes;
	public short bmiHeader_biBitCount;
	public int bmiHeader_biCompression;
	public int bmiHeader_biSizeImage;
	public int bmiHeader_biXPelsPerMeter;
	public int bmiHeader_biYPelsPerMeter;
	public int bmiHeader_biClrUsed;
	public int bmiHeader_biClrImportant;
	public byte[] bmiColors;
}

