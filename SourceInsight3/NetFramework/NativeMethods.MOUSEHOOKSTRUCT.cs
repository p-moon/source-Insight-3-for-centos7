public class MOUSEHOOKSTRUCT
{

	// Constructors
	public MOUSEHOOKSTRUCT() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int pt_x;
	public int pt_y;
	public System.IntPtr hWnd;
	public int wHitTestCode;
	public int dwExtraInfo;
}

