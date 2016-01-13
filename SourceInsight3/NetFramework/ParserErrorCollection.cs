public class ParserErrorCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ParserErrorCollection() {}
	public ParserErrorCollection(ParserError[] value) {}

	// Methods
	public int Add(ParserError value) {}
	public void AddRange(ParserError[] value) {}
	public void AddRange(ParserErrorCollection value) {}
	public bool Contains(ParserError value) {}
	public void CopyTo(ParserError[] array, int index) {}
	public int IndexOf(ParserError value) {}
	public void Insert(int index, ParserError value) {}
	public void Remove(ParserError value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ParserError Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

