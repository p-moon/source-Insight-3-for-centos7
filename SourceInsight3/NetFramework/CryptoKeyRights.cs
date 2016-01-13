public class CryptoKeyRights : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public CryptoKeyRights ReadData;
	public CryptoKeyRights WriteData;
	public CryptoKeyRights ReadExtendedAttributes;
	public CryptoKeyRights WriteExtendedAttributes;
	public CryptoKeyRights ReadAttributes;
	public CryptoKeyRights WriteAttributes;
	public CryptoKeyRights Delete;
	public CryptoKeyRights ReadPermissions;
	public CryptoKeyRights ChangePermissions;
	public CryptoKeyRights TakeOwnership;
	public CryptoKeyRights Synchronize;
	public CryptoKeyRights FullControl;
	public CryptoKeyRights GenericAll;
	public CryptoKeyRights GenericExecute;
	public CryptoKeyRights GenericWrite;
	public CryptoKeyRights GenericRead;
}

