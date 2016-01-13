public class CryptographicProviderType : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public CryptographicProviderType None;
	public CryptographicProviderType RsaFull;
	public CryptographicProviderType RsqSig;
	public CryptographicProviderType Dss;
	public CryptographicProviderType Fortezza;
	public CryptographicProviderType MicrosoftExchange;
	public CryptographicProviderType Ssl;
	public CryptographicProviderType SttMer;
	public CryptographicProviderType SttAcq;
	public CryptographicProviderType SttBrnd;
	public CryptographicProviderType SttRoot;
	public CryptographicProviderType SttIss;
}

