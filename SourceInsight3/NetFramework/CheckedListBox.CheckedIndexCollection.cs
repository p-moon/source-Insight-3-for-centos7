public class CheckedIndexCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public bool Contains(int index) {}
	public virtual void CopyTo(System.Array dest, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public int IndexOf(int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public int Item { get{} }
}

