public class TokenAccessLevels : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public TokenAccessLevels AssignPrimary;
	public TokenAccessLevels Duplicate;
	public TokenAccessLevels Impersonate;
	public TokenAccessLevels Query;
	public TokenAccessLevels QuerySource;
	public TokenAccessLevels AdjustPrivileges;
	public TokenAccessLevels AdjustGroups;
	public TokenAccessLevels AdjustDefault;
	public TokenAccessLevels AdjustSessionId;
	public TokenAccessLevels Read;
	public TokenAccessLevels Write;
	public TokenAccessLevels AllAccess;
	public TokenAccessLevels MaximumAllowed;
}

