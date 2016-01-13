public class X509ChainStatusFlags : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public X509ChainStatusFlags NoError;
	public X509ChainStatusFlags NotTimeValid;
	public X509ChainStatusFlags NotTimeNested;
	public X509ChainStatusFlags Revoked;
	public X509ChainStatusFlags NotSignatureValid;
	public X509ChainStatusFlags NotValidForUsage;
	public X509ChainStatusFlags UntrustedRoot;
	public X509ChainStatusFlags RevocationStatusUnknown;
	public X509ChainStatusFlags Cyclic;
	public X509ChainStatusFlags InvalidExtension;
	public X509ChainStatusFlags InvalidPolicyConstraints;
	public X509ChainStatusFlags InvalidBasicConstraints;
	public X509ChainStatusFlags InvalidNameConstraints;
	public X509ChainStatusFlags HasNotSupportedNameConstraint;
	public X509ChainStatusFlags HasNotDefinedNameConstraint;
	public X509ChainStatusFlags HasNotPermittedNameConstraint;
	public X509ChainStatusFlags HasExcludedNameConstraint;
	public X509ChainStatusFlags PartialChain;
	public X509ChainStatusFlags CtlNotTimeValid;
	public X509ChainStatusFlags CtlNotSignatureValid;
	public X509ChainStatusFlags CtlNotValidForUsage;
	public X509ChainStatusFlags OfflineRevocation;
	public X509ChainStatusFlags NoIssuanceChainPolicy;
}

