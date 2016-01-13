public class CheckedItemCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public virtual bool Contains(object item) {}
	public virtual int IndexOf(object item) {}
	public virtual void CopyTo(System.Array dest, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public object Item { get{} set{} }
	public bool IsReadOnly { get{} }
}

