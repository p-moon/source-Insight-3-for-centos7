public class STARTUPINFO_I
{

	// Constructors
	public STARTUPINFO_I() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int cb;
	public System.IntPtr lpReserved;
	public System.IntPtr lpDesktop;
	public System.IntPtr lpTitle;
	public int dwX;
	public int dwY;
	public int dwXSize;
	public int dwYSize;
	public int dwXCountChars;
	public int dwYCountChars;
	public int dwFillAttribute;
	public int dwFlags;
	public short wShowWindow;
	public short cbReserved2;
	public System.IntPtr lpReserved2;
	public System.IntPtr hStdInput;
	public System.IntPtr hStdOutput;
	public System.IntPtr hStdError;
}

