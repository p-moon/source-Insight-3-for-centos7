public class ActiveDirectorySecurity : System.Security.AccessControl.DirectoryObjectSecurity
{

	// Constructors
	public ActiveDirectorySecurity() {}

	// Methods
	public void AddAccessRule(ActiveDirectoryAccessRule rule) {}
	public void SetAccessRule(ActiveDirectoryAccessRule rule) {}
	public void ResetAccessRule(ActiveDirectoryAccessRule rule) {}
	public void RemoveAccess(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.AccessControlType type) {}
	public bool RemoveAccessRule(ActiveDirectoryAccessRule rule) {}
	public void RemoveAccessRuleSpecific(ActiveDirectoryAccessRule rule) {}
	public virtual bool ModifyAccessRule(System.Security.AccessControl.AccessControlModification modification, System.Security.AccessControl.AccessRule ruleout , System.Boolean& modified) {}
	public virtual void PurgeAccessRules(System.Security.Principal.IdentityReference identity) {}
	public void AddAuditRule(ActiveDirectoryAuditRule rule) {}
	public void SetAuditRule(ActiveDirectoryAuditRule rule) {}
	public void RemoveAudit(System.Security.Principal.IdentityReference identity) {}
	public bool RemoveAuditRule(ActiveDirectoryAuditRule rule) {}
	public void RemoveAuditRuleSpecific(ActiveDirectoryAuditRule rule) {}
	public virtual bool ModifyAuditRule(System.Security.AccessControl.AccessControlModification modification, System.Security.AccessControl.AuditRule ruleout , System.Boolean& modified) {}
	public virtual void PurgeAuditRules(System.Security.Principal.IdentityReference identity) {}
	public virtual System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) {}
	public virtual System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type, System.Guid objectGuid, System.Guid inheritedObjectGuid) {}
	public virtual System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) {}
	public virtual System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags, System.Guid objectGuid, System.Guid inheritedObjectGuid) {}
	public System.Security.AccessControl.AuthorizationRuleCollection GetAccessRules(bool includeExplicit, bool includeInherited, Type targetType) {}
	public System.Security.AccessControl.AuthorizationRuleCollection GetAuditRules(bool includeExplicit, bool includeInherited, Type targetType) {}
	public System.Security.Principal.IdentityReference GetOwner(Type targetType) {}
	public void SetOwner(System.Security.Principal.IdentityReference identity) {}
	public System.Security.Principal.IdentityReference GetGroup(Type targetType) {}
	public void SetGroup(System.Security.Principal.IdentityReference identity) {}
	public void SetAccessRuleProtection(bool isProtected, bool preserveInheritance) {}
	public void SetAuditRuleProtection(bool isProtected, bool preserveInheritance) {}
	public string GetSecurityDescriptorSddlForm(System.Security.AccessControl.AccessControlSections includeSections) {}
	public void SetSecurityDescriptorSddlForm(string sddlForm) {}
	public void SetSecurityDescriptorSddlForm(string sddlForm, System.Security.AccessControl.AccessControlSections includeSections) {}
	public byte[] GetSecurityDescriptorBinaryForm() {}
	public void SetSecurityDescriptorBinaryForm(byte[] binaryForm) {}
	public void SetSecurityDescriptorBinaryForm(byte[] binaryForm, System.Security.AccessControl.AccessControlSections includeSections) {}
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

