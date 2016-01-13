public class NotifyFilters : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public NotifyFilters FileName;
	public NotifyFilters DirectoryName;
	public NotifyFilters Attributes;
	public NotifyFilters Size;
	public NotifyFilters LastWrite;
	public NotifyFilters LastAccess;
	public NotifyFilters CreationTime;
	public NotifyFilters Security;
}

