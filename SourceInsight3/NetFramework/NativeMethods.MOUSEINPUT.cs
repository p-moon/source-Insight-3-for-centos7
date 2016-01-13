public class MOUSEINPUT : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public int dx;
	public int dy;
	public int mouseData;
	public int dwFlags;
	public int time;
	public System.IntPtr dwExtraInfo;
}

