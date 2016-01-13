public class BITMAPINFO
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

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
	public byte bmiColors_rgbBlue;
	public byte bmiColors_rgbGreen;
	public byte bmiColors_rgbRed;
	public byte bmiColors_rgbReserved;
}

