public class ReferenceList : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ReferenceList() {}

	// Methods
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual int Add(object value) {}
	public virtual void Clear() {}
	public virtual bool Contains(object value) {}
	public virtual int IndexOf(object value) {}
	public virtual void Insert(int index, object value) {}
	public virtual void Remove(object value) {}
	public virtual void RemoveAt(int index) {}
	public EncryptedReference Item(int index) {}
	public virtual void CopyTo(System.Array array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public EncryptedReference ItemOf { get{} set{} }
	public object SyncRoot { get{} }
	public bool IsSynchronized { get{} }
}

