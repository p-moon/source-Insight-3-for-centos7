public class GenericAcl : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public abstract virtual void GetBinaryForm(byte[] binaryForm, int offset) {}
	public void CopyTo(GenericAce[] array, int index) {}
	public AceEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public byte AclRevision;
	public byte AclRevisionDS;
	public int MaxBinaryLength;

	// Properties
	public byte Revision { get{} }
	public int BinaryLength { get{} }
	public GenericAce Item { get{} set{} }
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}

