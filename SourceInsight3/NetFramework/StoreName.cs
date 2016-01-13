public class StoreName : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public StoreName AddressBook;
	public StoreName AuthRoot;
	public StoreName CertificateAuthority;
	public StoreName Disallowed;
	public StoreName My;
	public StoreName Root;
	public StoreName TrustedPeople;
	public StoreName TrustedPublisher;
}

