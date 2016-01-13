public class EVENTMSG
{

	// Constructors
	public EVENTMSG() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int message;
	public int paramL;
	public int paramH;
	public int time;
	public System.IntPtr hwnd;
}

