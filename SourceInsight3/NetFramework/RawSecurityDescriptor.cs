public class RawSecurityDescriptor : GenericSecurityDescriptor
{

	// Constructors
	public RawSecurityDescriptor(ControlFlags flags, System.Security.Principal.SecurityIdentifier owner, System.Security.Principal.SecurityIdentifier group, RawAcl systemAcl, RawAcl discretionaryAcl) {}
	public RawSecurityDescriptor(string sddlForm) {}
	public RawSecurityDescriptor(byte[] binaryForm, int offset) {}

	// Methods
	public void SetFlags(ControlFlags flags) {}
	public string GetSddlForm(AccessControlSections includeSections) {}
	public void GetBinaryForm(byte[] binaryForm, int offset) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ControlFlags ControlFlags { get{} }
	public System.Security.Principal.SecurityIdentifier Owner { get{} set{} }
	public System.Security.Principal.SecurityIdentifier Group { get{} set{} }
	public RawAcl SystemAcl { get{} set{} }
	public RawAcl DiscretionaryAcl { get{} set{} }
	public byte ResourceManagerControl { get{} set{} }
	public int BinaryLength { get{} }
}

