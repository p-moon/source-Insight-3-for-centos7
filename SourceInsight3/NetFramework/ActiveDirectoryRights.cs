public class ActiveDirectoryRights : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public ActiveDirectoryRights Delete;
	public ActiveDirectoryRights ReadControl;
	public ActiveDirectoryRights WriteDacl;
	public ActiveDirectoryRights WriteOwner;
	public ActiveDirectoryRights Synchronize;
	public ActiveDirectoryRights AccessSystemSecurity;
	public ActiveDirectoryRights GenericRead;
	public ActiveDirectoryRights GenericWrite;
	public ActiveDirectoryRights GenericExecute;
	public ActiveDirectoryRights GenericAll;
	public ActiveDirectoryRights CreateChild;
	public ActiveDirectoryRights DeleteChild;
	public ActiveDirectoryRights ListChildren;
	public ActiveDirectoryRights Self;
	public ActiveDirectoryRights ReadProperty;
	public ActiveDirectoryRights WriteProperty;
	public ActiveDirectoryRights DeleteTree;
	public ActiveDirectoryRights ListObject;
	public ActiveDirectoryRights ExtendedRight;
}

