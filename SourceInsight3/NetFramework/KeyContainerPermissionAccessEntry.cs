public class KeyContainerPermissionAccessEntry
{

	// Constructors
	public KeyContainerPermissionAccessEntry(string keyContainerName, KeyContainerPermissionFlags flags) {}
	public KeyContainerPermissionAccessEntry(System.Security.Cryptography.CspParameters parameters, KeyContainerPermissionFlags flags) {}
	public KeyContainerPermissionAccessEntry(string keyStore, string providerName, int providerType, string keyContainerName, int keySpec, KeyContainerPermissionFlags flags) {}

	// Methods
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string KeyStore { get{} set{} }
	public string ProviderName { get{} set{} }
	public int ProviderType { get{} set{} }
	public string KeyContainerName { get{} set{} }
	public int KeySpec { get{} set{} }
	public KeyContainerPermissionFlags Flags { get{} set{} }
}

