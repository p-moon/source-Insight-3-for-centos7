public class MimeTextMatchCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public MimeTextMatchCollection() {}

	// Methods
	public int Add(MimeTextMatch match) {}
	public void Insert(int index, MimeTextMatch match) {}
	public int IndexOf(MimeTextMatch match) {}
	public bool Contains(MimeTextMatch match) {}
	public void Remove(MimeTextMatch match) {}
	public void CopyTo(MimeTextMatch[] array, int index) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MimeTextMatch Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

