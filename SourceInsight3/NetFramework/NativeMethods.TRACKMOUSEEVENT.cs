public class TRACKMOUSEEVENT
{

	// Constructors
	public TRACKMOUSEEVENT() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int cbSize;
	public int dwFlags;
	public System.IntPtr hwndTrack;
	public int dwHoverTime;
}

