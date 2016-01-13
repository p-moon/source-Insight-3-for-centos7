public class NMCUSTOMDRAW : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public NMHDR nmcd;
	public int dwDrawStage;
	public System.IntPtr hdc;
	public RECT rc;
	public System.IntPtr dwItemSpec;
	public int uItemState;
	public System.IntPtr lItemlParam;
}

