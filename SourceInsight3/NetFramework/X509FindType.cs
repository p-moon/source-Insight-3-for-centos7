public class X509FindType : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public X509FindType FindByThumbprint;
	public X509FindType FindBySubjectName;
	public X509FindType FindBySubjectDistinguishedName;
	public X509FindType FindByIssuerName;
	public X509FindType FindByIssuerDistinguishedName;
	public X509FindType FindBySerialNumber;
	public X509FindType FindByTimeValid;
	public X509FindType FindByTimeNotYetValid;
	public X509FindType FindByTimeExpired;
	public X509FindType FindByTemplateName;
	public X509FindType FindByApplicationPolicy;
	public X509FindType FindByCertificatePolicy;
	public X509FindType FindByExtension;
	public X509FindType FindByKeyUsage;
	public X509FindType FindBySubjectKeyIdentifier;
}

