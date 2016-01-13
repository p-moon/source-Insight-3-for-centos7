public class LVFINDINFO : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public int flags;
	public string psz;
	public System.IntPtr lParam;
	public int ptX;
	public int ptY;
	public int vkDirection;
}

