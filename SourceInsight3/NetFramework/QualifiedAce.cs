public class QualifiedAce : KnownAce
{

	// Methods
	public byte[] GetOpaque() {}
	public void SetOpaque(byte[] opaque) {}
	public abstract virtual void GetBinaryForm(byte[] binaryForm, int offset) {}
	public GenericAce Copy() {}
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
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
	public int BinaryLength { get{} }
}

