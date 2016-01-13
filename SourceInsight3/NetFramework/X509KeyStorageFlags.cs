public class X509KeyStorageFlags : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public X509KeyStorageFlags DefaultKeySet;
	public X509KeyStorageFlags UserKeySet;
	public X509KeyStorageFlags MachineKeySet;
	public X509KeyStorageFlags Exportable;
	public X509KeyStorageFlags UserProtected;
	public X509KeyStorageFlags PersistKeySet;
}

