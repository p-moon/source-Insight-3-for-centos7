public class WINDOWPOS : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public System.IntPtr hwnd;
	public System.IntPtr hwndInsertAfter;
	public int x;
	public int y;
	public int cx;
	public int cy;
	public int flags;
}

