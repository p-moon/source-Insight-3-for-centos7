public class EmbeddedMailObjectsCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public EmbeddedMailObjectsCollection() {}

	// Methods
	public int Add(EmbeddedMailObject value) {}
	public bool Contains(EmbeddedMailObject value) {}
	public void CopyTo(EmbeddedMailObject[] array, int index) {}
	public int IndexOf(EmbeddedMailObject value) {}
	public void Insert(int index, EmbeddedMailObject value) {}
	public void Remove(EmbeddedMailObject value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public EmbeddedMailObject Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

