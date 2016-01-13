public class PAINTSTRUCT : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public System.IntPtr hdc;
	public bool fErase;
	public int rcPaint_left;
	public int rcPaint_top;
	public int rcPaint_right;
	public int rcPaint_bottom;
	public bool fRestore;
	public bool fIncUpdate;
	public int reserved1;
	public int reserved2;
	public int reserved3;
	public int reserved4;
	public int reserved5;
	public int reserved6;
	public int reserved7;
	public int reserved8;
}

