public class RawAcl : GenericAcl, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public RawAcl(byte revision, int capacity) {}
	public RawAcl(byte[] binaryForm, int offset) {}

	// Methods
	public virtual void GetBinaryForm(byte[] binaryForm, int offset) {}
	public void InsertAce(int index, GenericAce ace) {}
	public void RemoveAce(int index) {}
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
	public GenericAce Item { get{} set{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}

