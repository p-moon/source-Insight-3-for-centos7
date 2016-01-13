public class ICONDIRENTRY : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public byte bWidth;
	public byte bHeight;
	public byte bColorCount;
	public byte bReserved;
	public short wPlanes;
	public short wBitCount;
	public int dwBytesInRes;
	public int dwImageOffset;
}

