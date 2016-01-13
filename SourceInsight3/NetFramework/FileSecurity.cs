public class FileSecurity : FileSystemSecurity
{

	// Constructors
	public FileSecurity() {}
	public FileSecurity(string fileName, AccessControlSections includeSections) {}

	// Methods
	public virtual AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type) {}
	public virtual AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags) {}
	public void AddAccessRule(FileSystemAccessRule rule) {}
	public void SetAccessRule(FileSystemAccessRule rule) {}
	public void ResetAccessRule(FileSystemAccessRule rule) {}
	public bool RemoveAccessRule(FileSystemAccessRule rule) {}
	public void RemoveAccessRuleAll(FileSystemAccessRule rule) {}
	public void RemoveAccessRuleSpecific(FileSystemAccessRule rule) {}
	public void AddAuditRule(FileSystemAuditRule rule) {}
	public void SetAuditRule(FileSystemAuditRule rule) {}
	public bool RemoveAuditRule(FileSystemAuditRule rule) {}
	public void RemoveAuditRuleAll(FileSystemAuditRule rule) {}
	public void RemoveAuditRuleSpecific(FileSystemAuditRule rule) {}
	public AuthorizationRuleCollection GetAccessRules(bool includeExplicit, bool includeInherited, Type targetType) {}
	public AuthorizationRuleCollection GetAuditRules(bool includeExplicit, bool includeInherited, Type targetType) {}
	public System.Security.Principal.IdentityReference GetOwner(Type targetType) {}
	public void SetOwner(System.Security.Principal.IdentityReference identity) {}
	public System.Security.Principal.IdentityReference GetGroup(Type targetType) {}
	public void SetGroup(System.Security.Principal.IdentityReference identity) {}
	public virtual void PurgeAccessRules(System.Security.Principal.IdentityReference identity) {}
	public virtual void PurgeAuditRules(System.Security.Principal.IdentityReference identity) {}
	public void SetAccessRuleProtection(bool isProtected, bool preserveInheritance) {}
	public void SetAuditRuleProtection(bool isProtected, bool preserveInheritance) {}
	public string GetSecurityDescriptorSddlForm(AccessControlSections includeSections) {}
	public void SetSecurityDescriptorSddlForm(string sddlForm) {}
	public void SetSecurityDescriptorSddlForm(string sddlForm, AccessControlSections includeSections) {}
	public byte[] GetSecurityDescriptorBinaryForm() {}
	public void SetSecurityDescriptorBinaryForm(byte[] binaryForm) {}
	public void SetSecurityDescriptorBinaryForm(byte[] binaryForm, AccessControlSections includeSections) {}
	public virtual bool ModifyAccessRule(AccessControlModification modification, AccessRule ruleout , System.Boolean& modified) {}
	public virtual bool ModifyAuditRule(AccessControlModification modification, AuditRule ruleout , System.Boolean& modified) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Type AccessRightType { get{} }
	public Type AccessRuleType { get{} }
	public Type AuditRuleType { get{} }
	public bool AreAccessRulesProtected { get{} }
	public bool AreAuditRulesProtected { get{} }
	public bool AreAccessRulesCanonical { get{} }
	public bool AreAuditRulesCanonical { get{} }
}

