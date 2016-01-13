public class TypeLibVarFlags : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public TypeLibVarFlags FReadOnly;
	public TypeLibVarFlags FSource;
	public TypeLibVarFlags FBindable;
	public TypeLibVarFlags FRequestEdit;
	public TypeLibVarFlags FDisplayBind;
	public TypeLibVarFlags FDefaultBind;
	public TypeLibVarFlags FHidden;
	public TypeLibVarFlags FRestricted;
	public TypeLibVarFlags FDefaultCollelem;
	public TypeLibVarFlags FUiDefault;
	public TypeLibVarFlags FNonBrowsable;
	public TypeLibVarFlags FReplaceable;
	public TypeLibVarFlags FImmediateBind;
}

