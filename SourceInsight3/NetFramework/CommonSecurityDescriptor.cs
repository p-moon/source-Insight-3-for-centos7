public class CommonSecurityDescriptor : GenericSecurityDescriptor
{

	// Constructors
	public CommonSecurityDescriptor(bool isContainer, bool isDS, ControlFlags flags, System.Security.Principal.SecurityIdentifier owner, System.Security.Principal.SecurityIdentifier group, SystemAcl systemAcl, DiscretionaryAcl discretionaryAcl) {}
	public CommonSecurityDescriptor(bool isContainer, bool isDS, RawSecurityDescriptor rawSecurityDescriptor) {}
	public CommonSecurityDescriptor(bool isContainer, bool isDS, string sddlForm) {}
	public CommonSecurityDescriptor(bool isContainer, bool isDS, byte[] binaryForm, int offset) {}

	// Methods
	public void SetSystemAclProtection(bool isProtected, bool preserveInheritance) {}
	public void SetDiscretionaryAclProtection(bool isProtected, bool preserveInheritance) {}
	public void PurgeAccessControl(System.Security.Principal.SecurityIdentifier sid) {}
	public void PurgeAudit(System.Security.Principal.SecurityIdentifier sid) {}
	public string GetSddlForm(AccessControlSections includeSections) {}
	public void GetBinaryForm(byte[] binaryForm, int offset) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsContainer { get{} }
	public bool IsDS { get{} }
	public ControlFlags ControlFlags { get{} }
	public System.Security.Principal.SecurityIdentifier Owner { get{} set{} }
	public System.Security.Principal.SecurityIdentifier Group { get{} set{} }
	public SystemAcl SystemAcl { get{} set{} }
	public DiscretionaryAcl DiscretionaryAcl { get{} set{} }
	public bool IsSystemAclCanonical { get{} }
	public bool IsDiscretionaryAclCanonical { get{} }
	public int BinaryLength { get{} }
}

