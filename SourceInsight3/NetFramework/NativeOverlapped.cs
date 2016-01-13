public class NativeOverlapped : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public System.IntPtr InternalLow;
	public System.IntPtr InternalHigh;
	public int OffsetLow;
	public int OffsetHigh;
	public System.IntPtr EventHandle;
}

