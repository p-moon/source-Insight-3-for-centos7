public class X509ContentType : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public X509ContentType Unknown;
	public X509ContentType Cert;
	public X509ContentType SerializedCert;
	public X509ContentType Pfx;
	public X509ContentType Pkcs12;
	public X509ContentType SerializedStore;
	public X509ContentType Pkcs7;
	public X509ContentType Authenticode;
}

