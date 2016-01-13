public class RegistrySecurity : NativeObjectSecurity
{

	// Constructors
	public RegistrySecurity() {}

	// Methods
	public virtual AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type) {}
	public virtual AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags) {}
	public void AddAccessRule(RegistryAccessRule rule) {}
	public void SetAccessRule(RegistryAccessRule rule) {}
	public void ResetAccessRule(RegistryAccessRule rule) {}
	public bool RemoveAccessRule(RegistryAccessRule rule) {}
	public void RemoveAccessRuleAll(RegistryAccessRule rule) {}
	public void RemoveAccessRuleSpecific(RegistryAccessRule rule) {}
	public void AddAuditRule(RegistryAuditRule rule) {}
	public void SetAuditRule(RegistryAuditRule rule) {}
	public bool RemoveAuditRule(RegistryAuditRule rule) {}
	public void RemoveAuditRuleAll(RegistryAuditRule rule) {}
	public void RemoveAuditRuleSpecific(RegistryAuditRule rule) {}
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

