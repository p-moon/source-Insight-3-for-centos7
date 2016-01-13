public class CustomAce : GenericAce
{

	// Constructors
	public CustomAce(AceType type, AceFlags flags, byte[] opaque) {}

	// Methods
	public byte[] GetOpaque() {}
	public void SetOpaque(byte[] opaque) {}
	public virtual void GetBinaryForm(byte[] binaryForm, int offset) {}
	public GenericAce Copy() {}
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public int MaxOpaqueLength;

	// Properties
	public int OpaqueLength { get{} }
	public int BinaryLength { get{} }
	public AceType AceType { get{} }
	public AceFlags AceFlags { get{} set{} }
	public bool IsInherited { get{} }
	public InheritanceFlags InheritanceFlags { get{} }
	public PropagationFlags PropagationFlags { get{} }
	public AuditFlags AuditFlags { get{} }
}

