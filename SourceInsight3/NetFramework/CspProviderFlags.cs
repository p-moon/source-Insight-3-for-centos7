public class CspProviderFlags : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public CspProviderFlags NoFlags;
	public CspProviderFlags UseMachineKeyStore;
	public CspProviderFlags UseDefaultKeyContainer;
	public CspProviderFlags UseNonExportableKey;
	public CspProviderFlags UseExistingKey;
	public CspProviderFlags UseArchivableKey;
	public CspProviderFlags UseUserProtectedKey;
	public CspProviderFlags NoPrompt;
}

