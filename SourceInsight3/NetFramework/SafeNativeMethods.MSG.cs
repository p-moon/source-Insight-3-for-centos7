public class MSG : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public System.IntPtr hwnd;
	public int message;
	public System.IntPtr wParam;
	public System.IntPtr lParam;
	public int time;
	public int pt_x;
	public int pt_y;
}

