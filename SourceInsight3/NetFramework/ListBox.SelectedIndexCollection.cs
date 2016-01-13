public class SelectedIndexCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public SelectedIndexCollection(ListBox owner) {}

	// Methods
	public bool Contains(int selectedIndex) {}
	public int IndexOf(int selectedIndex) {}
	public virtual void CopyTo(System.Array destination, int index) {}
	public void Clear() {}
	public void Add(int index) {}
	public void Remove(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public int Item { get{} }
}

