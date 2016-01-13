public class CheckedIndexCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public CheckedIndexCollection(ListView owner) {}

	// Methods
	public bool Contains(int checkedIndex) {}
	public int IndexOf(int checkedIndex) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public int Item { get{} }
	public bool IsReadOnly { get{} }
}

