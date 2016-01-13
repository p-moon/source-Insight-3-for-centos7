public class CryptoKeyAccessRule : AccessRule
{

	// Constructors
	public CryptoKeyAccessRule(System.Security.Principal.IdentityReference identity, CryptoKeyRights cryptoKeyRights, AccessControlType type) {}
	public CryptoKeyAccessRule(string identity, CryptoKeyRights cryptoKeyRights, AccessControlType type) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CryptoKeyRights CryptoKeyRights { get{} }
	public AccessControlType AccessControlType { get{} }
	public System.Security.Principal.IdentityReference IdentityReference { get{} }
	public bool IsInherited { get{} }
	public InheritanceFlags InheritanceFlags { get{} }
	public PropagationFlags PropagationFlags { get{} }
}

