public class X509VerificationFlags : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public X509VerificationFlags NoFlag;
	public X509VerificationFlags IgnoreNotTimeValid;
	public X509VerificationFlags IgnoreCtlNotTimeValid;
	public X509VerificationFlags IgnoreNotTimeNested;
	public X509VerificationFlags IgnoreInvalidBasicConstraints;
	public X509VerificationFlags AllowUnknownCertificateAuthority;
	public X509VerificationFlags IgnoreWrongUsage;
	public X509VerificationFlags IgnoreInvalidName;
	public X509VerificationFlags IgnoreInvalidPolicy;
	public X509VerificationFlags IgnoreEndRevocationUnknown;
	public X509VerificationFlags IgnoreCtlSignerRevocationUnknown;
	public X509VerificationFlags IgnoreCertificateAuthorityRevocationUnknown;
	public X509VerificationFlags IgnoreRootRevocationUnknown;
	public X509VerificationFlags AllFlags;
}

