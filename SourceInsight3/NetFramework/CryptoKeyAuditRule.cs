public class CryptoKeyAuditRule : AuditRule
{

	// Constructors
	public CryptoKeyAuditRule(System.Security.Principal.IdentityReference identity, CryptoKeyRights cryptoKeyRights, AuditFlags flags) {}
	public CryptoKeyAuditRule(string identity, CryptoKeyRights cryptoKeyRights, AuditFlags flags) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CryptoKeyRights CryptoKeyRights { get{} }
	public AuditFlags AuditFlags { get{} }
	public System.Security.Principal.IdentityReference IdentityReference { get{} }
	public bool IsInherited { get{} }
	public InheritanceFlags InheritanceFlags { get{} }
	public PropagationFlags PropagationFlags { get{} }
}

