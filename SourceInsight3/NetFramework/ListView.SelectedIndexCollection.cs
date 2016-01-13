public class SelectedIndexCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public SelectedIndexCollection(ListView owner) {}

	// Methods
	public bool Contains(int selectedIndex) {}
	public int IndexOf(int selectedIndex) {}
	public int Add(int itemIndex) {}
	public void Clear() {}
	public virtual void CopyTo(System.Array dest, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void Remove(int itemIndex) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public int Item { get{} }
	public bool IsReadOnly { get{} }
}

