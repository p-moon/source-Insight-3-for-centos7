public class CspKeyContainerInfo
{

	// Constructors
	public CspKeyContainerInfo(CspParameters parameters) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool MachineKeyStore { get{} }
	public string ProviderName { get{} }
	public int ProviderType { get{} }
	public string KeyContainerName { get{} }
	public string UniqueKeyContainerName { get{} }
	public KeyNumber KeyNumber { get{} }
	public bool Exportable { get{} }
	public bool HardwareDevice { get{} }
	public bool Removable { get{} }
	public bool Accessible { get{} }
	public bool Protected { get{} }
	public System.Security.AccessControl.CryptoKeySecurity CryptoKeySecurity { get{} }
	public bool RandomlyGenerated { get{} }
}

