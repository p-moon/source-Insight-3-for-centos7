public class STATSTG : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public string pwcsName;
	public int type;
	public long cbSize;
	public FILETIME mtime;
	public FILETIME ctime;
	public FILETIME atime;
	public int grfMode;
	public int grfLocksSupported;
	public System.Guid clsid;
	public int grfStateBits;
	public int reserved;
}

