public class GenericSecurityDescriptor
{

	// Methods
	public static bool IsSddlConversionSupported() {}
	public string GetSddlForm(AccessControlSections includeSections) {}
	public void GetBinaryForm(byte[] binaryForm, int offset) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public byte Revision { get{} }
	public ControlFlags ControlFlags { get{} }
	public System.Security.Principal.SecurityIdentifier Owner { get{} set{} }
	public System.Security.Principal.SecurityIdentifier Group { get{} set{} }
	public int BinaryLength { get{} }
}

