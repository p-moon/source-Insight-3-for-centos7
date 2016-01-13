public class DISPPARAMS : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public System.IntPtr rgvarg;
	public System.IntPtr rgdispidNamedArgs;
	public int cArgs;
	public int cNamedArgs;
}

