public class GenericAce
{

	// Methods
	public static GenericAce CreateFromBinaryForm(byte[] binaryForm, int offset) {}
	public abstract virtual void GetBinaryForm(byte[] binaryForm, int offset) {}
	public GenericAce Copy() {}
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public static bool op_Equality(GenericAce left, GenericAce right) {}
	public static bool op_Inequality(GenericAce left, GenericAce right) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public AceType AceType { get{} }
	public AceFlags AceFlags { get{} set{} }
	public bool IsInherited { get{} }
	public InheritanceFlags InheritanceFlags { get{} }
	public PropagationFlags PropagationFlags { get{} }
	public AuditFlags AuditFlags { get{} }
	public int BinaryLength { get{} }
}

