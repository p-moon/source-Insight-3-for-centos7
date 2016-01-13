public class StandardAccessRights : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public StandardAccessRights Delete;
	public StandardAccessRights ReadSecurity;
	public StandardAccessRights WriteSecurity;
	public StandardAccessRights Synchronize;
	public StandardAccessRights ModifyOwner;
	public StandardAccessRights Read;
	public StandardAccessRights Write;
	public StandardAccessRights Execute;
	public StandardAccessRights Required;
	public StandardAccessRights All;
	public StandardAccessRights None;
}

