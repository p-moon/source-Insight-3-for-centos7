public class MethodImplAttributes : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, System.IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(System.IFormatProvider provider) {}
	public virtual System.TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public MethodImplAttributes CodeTypeMask;
	public MethodImplAttributes IL;
	public MethodImplAttributes Native;
	public MethodImplAttributes OPTIL;
	public MethodImplAttributes Runtime;
	public MethodImplAttributes ManagedMask;
	public MethodImplAttributes Unmanaged;
	public MethodImplAttributes Managed;
	public MethodImplAttributes ForwardRef;
	public MethodImplAttributes PreserveSig;
	public MethodImplAttributes InternalCall;
	public MethodImplAttributes Synchronized;
	public MethodImplAttributes NoInlining;
	public MethodImplAttributes MaxMethodImplVal;
}

