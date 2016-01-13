public class X509NameType : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public X509NameType SimpleName;
	public X509NameType EmailName;
	public X509NameType UpnName;
	public X509NameType DnsName;
	public X509NameType DnsFromAlternativeName;
	public X509NameType UrlName;
}

