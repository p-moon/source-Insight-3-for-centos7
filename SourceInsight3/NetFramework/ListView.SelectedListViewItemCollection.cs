public class SelectedListViewItemCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public SelectedListViewItemCollection(ListView owner) {}

	// Methods
	public virtual void Clear() {}
	public virtual bool ContainsKey(string key) {}
	public bool Contains(ListViewItem item) {}
	public virtual void CopyTo(System.Array dest, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public int IndexOf(ListViewItem item) {}
	public virtual int IndexOfKey(string key) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public ListViewItem Item { get{} }
	public ListViewItem Item { get{} }
	public bool IsReadOnly { get{} }
}

