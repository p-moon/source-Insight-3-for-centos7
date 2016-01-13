public class TypeLibTypeFlags : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public TypeLibTypeFlags FAppObject;
	public TypeLibTypeFlags FCanCreate;
	public TypeLibTypeFlags FLicensed;
	public TypeLibTypeFlags FPreDeclId;
	public TypeLibTypeFlags FHidden;
	public TypeLibTypeFlags FControl;
	public TypeLibTypeFlags FDual;
	public TypeLibTypeFlags FNonExtensible;
	public TypeLibTypeFlags FOleAutomation;
	public TypeLibTypeFlags FRestricted;
	public TypeLibTypeFlags FAggregatable;
	public TypeLibTypeFlags FReplaceable;
	public TypeLibTypeFlags FDispatchable;
	public TypeLibTypeFlags FReverseBind;
}

