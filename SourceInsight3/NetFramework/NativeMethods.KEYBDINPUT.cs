public class KEYBDINPUT : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public short wVk;
	public short wScan;
	public int dwFlags;
	public int time;
	public System.IntPtr dwExtraInfo;
}

