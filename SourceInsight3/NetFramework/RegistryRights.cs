public class RegistryRights : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public RegistryRights QueryValues;
	public RegistryRights SetValue;
	public RegistryRights CreateSubKey;
	public RegistryRights EnumerateSubKeys;
	public RegistryRights Notify;
	public RegistryRights CreateLink;
	public RegistryRights ExecuteKey;
	public RegistryRights ReadKey;
	public RegistryRights WriteKey;
	public RegistryRights Delete;
	public RegistryRights ReadPermissions;
	public RegistryRights ChangePermissions;
	public RegistryRights TakeOwnership;
	public RegistryRights FullControl;
}

