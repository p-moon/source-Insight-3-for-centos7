public class INPUTUNION : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public MOUSEINPUT mi;
	public KEYBDINPUT ki;
	public HARDWAREINPUT hi;
}

