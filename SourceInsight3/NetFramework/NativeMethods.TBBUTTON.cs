public class TBBUTTON : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public int iBitmap;
	public int idCommand;
	public byte fsState;
	public byte fsStyle;
	public byte bReserved0;
	public byte bReserved1;
	public System.IntPtr dwData;
	public System.IntPtr iString;
}

