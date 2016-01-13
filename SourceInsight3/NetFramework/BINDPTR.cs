public class BINDPTR : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public System.IntPtr lpfuncdesc;
	public System.IntPtr lpvardesc;
	public System.IntPtr lptcomp;
}

