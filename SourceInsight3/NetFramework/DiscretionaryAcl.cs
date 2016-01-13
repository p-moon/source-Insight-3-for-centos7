public class DiscretionaryAcl : CommonAcl, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public DiscretionaryAcl(bool isContainer, bool isDS, int capacity) {}
	public DiscretionaryAcl(bool isContainer, bool isDS, byte revision, int capacity) {}
	public DiscretionaryAcl(bool isContainer, bool isDS, RawAcl rawAcl) {}

	// Methods
	public void AddAccess(AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags) {}
	public void SetAccess(AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags) {}
	public bool RemoveAccess(AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags) {}
	public void RemoveAccessSpecific(AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags) {}
	public void AddAccess(AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, ObjectAceFlags objectFlags, System.Guid objectType, System.Guid inheritedObjectType) {}
	public void SetAccess(AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, ObjectAceFlags objectFlags, System.Guid objectType, System.Guid inheritedObjectType) {}
	public bool RemoveAccess(AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, ObjectAceFlags objectFlags, System.Guid objectType, System.Guid inheritedObjectType) {}
	public void RemoveAccessSpecific(AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, ObjectAceFlags objectFlags, System.Guid objectType, System.Guid inheritedObjectType) {}
	public virtual void GetBinaryForm(byte[] binaryForm, int offset) {}
	public void RemoveInheritedAces() {}
	public void Purge(System.Security.Principal.SecurityIdentifier sid) {}
	public void CopyTo(GenericAce[] array, int index) {}
	public AceEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public byte Revision { get{} }
	public int Count { get{} }
	public int BinaryLength { get{} }
	public bool IsCanonical { get{} }
	public bool IsContainer { get{} }
	public bool IsDS { get{} }
	public GenericAce Item { get{} set{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}

