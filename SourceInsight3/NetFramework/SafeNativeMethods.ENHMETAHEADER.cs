public class ENHMETAHEADER
{

	// Constructors
	public ENHMETAHEADER() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int iType;
	public int nSize;
	public int rclBounds_left;
	public int rclBounds_top;
	public int rclBounds_right;
	public int rclBounds_bottom;
	public int rclFrame_left;
	public int rclFrame_top;
	public int rclFrame_right;
	public int rclFrame_bottom;
	public int dSignature;
	public int nVersion;
	public int nBytes;
	public int nRecords;
	public short nHandles;
	public short sReserved;
	public int nDescription;
	public int offDescription;
	public int nPalEntries;
	public int szlDevice_cx;
	public int szlDevice_cy;
	public int szlMillimeters_cx;
	public int szlMillimeters_cy;
	public int cbPixelFormat;
	public int offPixelFormat;
	public int bOpenGL;
}

