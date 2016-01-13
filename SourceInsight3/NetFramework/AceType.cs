public class AceType : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public byte value__;
	public AceType AccessAllowed;
	public AceType AccessDenied;
	public AceType SystemAudit;
	public AceType SystemAlarm;
	public AceType AccessAllowedCompound;
	public AceType AccessAllowedObject;
	public AceType AccessDeniedObject;
	public AceType SystemAuditObject;
	public AceType SystemAlarmObject;
	public AceType AccessAllowedCallback;
	public AceType AccessDeniedCallback;
	public AceType AccessAllowedCallbackObject;
	public AceType AccessDeniedCallbackObject;
	public AceType SystemAuditCallback;
	public AceType SystemAlarmCallback;
	public AceType SystemAuditCallbackObject;
	public AceType SystemAlarmCallbackObject;
	public AceType MaxDefinedAceType;
}

