public class WindowsBuiltInRole : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public WindowsBuiltInRole Administrator;
	public WindowsBuiltInRole User;
	public WindowsBuiltInRole Guest;
	public WindowsBuiltInRole PowerUser;
	public WindowsBuiltInRole AccountOperator;
	public WindowsBuiltInRole SystemOperator;
	public WindowsBuiltInRole PrintOperator;
	public WindowsBuiltInRole BackupOperator;
	public WindowsBuiltInRole Replicator;
}

