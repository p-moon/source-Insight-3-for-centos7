public class CompoundAce : KnownAce
{

	// Constructors
	public CompoundAce(AceFlags flags, int accessMask, CompoundAceType compoundAceType, System.Security.Principal.SecurityIdentifier sid) {}

	// Methods
	public virtual void GetBinaryForm(byte[] binaryForm, int offset) {}
	public GenericAce Copy() {}
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public CompoundAceType CompoundAceType { get{} set{} }
	public int BinaryLength { get{} }
	public int AccessMask { get{} set{} }
	public System.Security.Principal.SecurityIdentifier SecurityIdentifier { get{} set{} }
	public AceType AceType { get{} }
	public AceFlags AceFlags { get{} set{} }
	public bool IsInherited { get{} }
	public InheritanceFlags InheritanceFlags { get{} }
	public PropagationFlags PropagationFlags { get{} }
	public AuditFlags AuditFlags { get{} }
}

