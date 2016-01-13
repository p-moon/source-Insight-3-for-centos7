public class HandleRef : System.ValueType
{

	// Constructors
	public HandleRef(object wrapper, System.IntPtr handle) {}

	// Methods
	public static System.IntPtr op_Explicit(HandleRef value) {}
	public static System.IntPtr ToIntPtr(HandleRef value) {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public object Wrapper { get{} }
	public System.IntPtr Handle { get{} }
}

