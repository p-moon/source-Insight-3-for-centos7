public class EDITSTREAM
{

	// Constructors
	public EDITSTREAM() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public System.IntPtr dwCookie;
	public int dwError;
	public EditStreamCallback pfnCallback;
}

