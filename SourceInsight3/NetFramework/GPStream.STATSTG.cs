public class STATSTG
{

	// Constructors
	public STATSTG() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public System.IntPtr pwcsName;
	public int type;
	public long cbSize;
	public long mtime;
	public long ctime;
	public long atime;
	public int grfMode;
	public int grfLocksSupported;
	public int clsid_data1;
	public short clsid_data2;
	public short clsid_data3;
	public byte clsid_b0;
	public byte clsid_b1;
	public byte clsid_b2;
	public byte clsid_b3;
	public byte clsid_b4;
	public byte clsid_b5;
	public byte clsid_b6;
	public byte clsid_b7;
	public int grfStateBits;
	public int reserved;
}

