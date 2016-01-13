public class CommonAcl : GenericAcl, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
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

