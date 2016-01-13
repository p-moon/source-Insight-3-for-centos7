public class ObjectAce : QualifiedAce
{

	// Constructors
	public ObjectAce(AceFlags aceFlags, AceQualifier qualifier, int accessMask, System.Security.Principal.SecurityIdentifier sid, ObjectAceFlags flags, System.Guid type, System.Guid inheritedType, bool isCallback, byte[] opaque) {}

	// Methods
	public static int MaxOpaqueLength(bool isCallback) {}
	public virtual void GetBinaryForm(byte[] binaryForm, int offset) {}
	public byte[] GetOpaque() {}
	public void SetOpaque(byte[] opaque) {}
	public GenericAce Copy() {}
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public ObjectAceFlags ObjectAceFlags { get{} set{} }
	public System.Guid ObjectAceType { get{} set{} }
	public System.Guid InheritedObjectAceType { get{} set{} }
	public int BinaryLength { get{} }
	public AceQualifier AceQualifier { get{} }
	public bool IsCallback { get{} }
	public int OpaqueLength { get{} }
	public int AccessMask { get{} set{} }
	public System.Security.Principal.SecurityIdentifier SecurityIdentifier { get{} set{} }
	public AceType AceType { get{} }
	public AceFlags AceFlags { get{} set{} }
	public bool IsInherited { get{} }
	public InheritanceFlags InheritanceFlags { get{} }
	public PropagationFlags PropagationFlags { get{} }
	public AuditFlags AuditFlags { get{} }
}

