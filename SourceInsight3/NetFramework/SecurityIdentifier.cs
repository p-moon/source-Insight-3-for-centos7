public class SecurityIdentifier : IdentityReference, IComparable<System.Security.Principal.SecurityIdentifier>
{

	// Constructors
	public SecurityIdentifier(string sddlForm) {}
	public SecurityIdentifier(byte[] binaryForm, int offset) {}
	public SecurityIdentifier(System.IntPtr binaryForm) {}
	public SecurityIdentifier(WellKnownSidType sidType, SecurityIdentifier domainSid) {}

	// Methods
	public virtual bool Equals(object o) {}
	public bool Equals(SecurityIdentifier sid) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual bool IsValidTargetType(Type targetType) {}
	public bool IsAccountSid() {}
	public virtual IdentityReference Translate(Type targetType) {}
	public static bool op_Equality(SecurityIdentifier left, SecurityIdentifier right) {}
	public static bool op_Inequality(SecurityIdentifier left, SecurityIdentifier right) {}
	public virtual int CompareTo(SecurityIdentifier sid) {}
	public bool IsWellKnown(WellKnownSidType type) {}
	public void GetBinaryForm(byte[] binaryForm, int offset) {}
	public bool IsEqualDomainSid(SecurityIdentifier sid) {}
	public Type GetType() {}

	// Fields
	public int MinBinaryLength;
	public int MaxBinaryLength;

	// Properties
	public int BinaryLength { get{} }
	public SecurityIdentifier AccountDomainSid { get{} }
	public string Value { get{} }
}

