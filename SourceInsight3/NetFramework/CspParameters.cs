public class CspParameters
{

	// Constructors
	public CspParameters() {}
	public CspParameters(int dwTypeIn) {}
	public CspParameters(int dwTypeIn, string strProviderNameIn) {}
	public CspParameters(int dwTypeIn, string strProviderNameIn, string strContainerNameIn) {}
	public CspParameters(int providerType, string providerName, string keyContainerName, System.Security.AccessControl.CryptoKeySecurity cryptoKeySecurity, System.Security.SecureString keyPassword) {}
	public CspParameters(int providerType, string providerName, string keyContainerName, System.Security.AccessControl.CryptoKeySecurity cryptoKeySecurity, System.IntPtr parentWindowHandle) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int ProviderType;
	public string ProviderName;
	public string KeyContainerName;
	public int KeyNumber;

	// Properties
	public CspProviderFlags Flags { get{} set{} }
	public System.Security.AccessControl.CryptoKeySecurity CryptoKeySecurity { get{} set{} }
	public System.Security.SecureString KeyPassword { get{} set{} }
	public System.IntPtr ParentWindowHandle { get{} set{} }
}

