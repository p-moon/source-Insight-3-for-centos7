public class MimePartCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public MimePartCollection() {}

	// Methods
	public int Add(MimePart mimePart) {}
	public void Insert(int index, MimePart mimePart) {}
	public int IndexOf(MimePart mimePart) {}
	public bool Contains(MimePart mimePart) {}
	public void Remove(MimePart mimePart) {}
	public void CopyTo(MimePart[] array, int index) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MimePart Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

