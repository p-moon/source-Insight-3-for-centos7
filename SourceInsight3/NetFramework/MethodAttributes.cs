public class MethodAttributes : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public MethodAttributes MemberAccessMask;
	public MethodAttributes PrivateScope;
	public MethodAttributes Private;
	public MethodAttributes FamANDAssem;
	public MethodAttributes Assembly;
	public MethodAttributes Family;
	public MethodAttributes FamORAssem;
	public MethodAttributes Public;
	public MethodAttributes Static;
	public MethodAttributes Final;
	public MethodAttributes Virtual;
	public MethodAttributes HideBySig;
	public MethodAttributes CheckAccessOnOverride;
	public MethodAttributes VtableLayoutMask;
	public MethodAttributes ReuseSlot;
	public MethodAttributes NewSlot;
	public MethodAttributes Abstract;
	public MethodAttributes SpecialName;
	public MethodAttributes PinvokeImpl;
	public MethodAttributes UnmanagedExport;
	public MethodAttributes RTSpecialName;
	public MethodAttributes ReservedMask;
	public MethodAttributes HasSecurity;
	public MethodAttributes RequireSecObject;
}

