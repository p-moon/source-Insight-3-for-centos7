public class XmlQuerySequence<T> : IList<T>, ICollection<T>, IEnumerable<T>, System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection
{

	// Constructors
	public XmlQuerySequence() {}
	public XmlQuerySequence(int capacity) {}
	public XmlQuerySequence(T[] array, int size) {}
	public XmlQuerySequence(T value) {}

	// Methods
	public static XmlQuerySequence<T> CreateOrReuse(XmlQuerySequence<T> seq) {}
	public static XmlQuerySequence<T> CreateOrReuse(XmlQuerySequence<T> seq, T item) {}
	public virtual IEnumerator<T> GetEnumerator() {}
	public virtual bool Contains(T value) {}
	public virtual void CopyTo(T[] array, int index) {}
	public virtual int IndexOf(T value) {}
	public void Clear() {}
	public void Add(T value) {}
	public void SortByKeys(System.Array keys) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public XmlQuerySequence<T> Empty;

	// Properties
	public int Count { get{} }
	public T Item { get{} set{} }
}

