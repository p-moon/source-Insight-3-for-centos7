public class EncryptionPropertyCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public EncryptionPropertyCollection() {}

	// Methods
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public int Add(EncryptionProperty value) {}
	public virtual void Clear() {}
	public bool Contains(EncryptionProperty value) {}
	public int IndexOf(EncryptionProperty value) {}
	public void Insert(int index, EncryptionProperty value) {}
	public void Remove(EncryptionProperty value) {}
	public virtual void RemoveAt(int index) {}
	public EncryptionProperty Item(int index) {}
	public virtual void CopyTo(System.Array array, int index) {}
	public void CopyTo(EncryptionProperty[] array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsFixedSize { get{} }
	public bool IsReadOnly { get{} }
	public EncryptionProperty ItemOf { get{} set{} }
	public object SyncRoot { get{} }
	public bool IsSynchronized { get{} }
}

