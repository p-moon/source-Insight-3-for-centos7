public class ListViewItemCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ListViewItemCollection(ListView owner) {}

	// Methods
	public virtual ListViewItem Add(string text) {}
	public virtual ListViewItem Add(string text, int imageIndex) {}
	public virtual ListViewItem Add(ListViewItem value) {}
	public virtual ListViewItem Add(string text, string imageKey) {}
	public virtual ListViewItem Add(string key, string text, string imageKey) {}
	public virtual ListViewItem Add(string key, string text, int imageIndex) {}
	public void AddRange(ListViewItem[] items) {}
	public void AddRange(ListViewItemCollection items) {}
	public virtual void Clear() {}
	public bool Contains(ListViewItem item) {}
	public virtual bool ContainsKey(string key) {}
	public virtual void CopyTo(System.Array dest, int index) {}
	public ListViewItem[] Find(string key, bool searchAllSubItems) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public int IndexOf(ListViewItem item) {}
	public virtual int IndexOfKey(string key) {}
	public ListViewItem Insert(int index, ListViewItem item) {}
	public ListViewItem Insert(int index, string text) {}
	public ListViewItem Insert(int index, string text, int imageIndex) {}
	public ListViewItem Insert(int index, string text, string imageKey) {}
	public virtual ListViewItem Insert(int index, string key, string text, string imageKey) {}
	public virtual ListViewItem Insert(int index, string key, string text, int imageIndex) {}
	public virtual void Remove(ListViewItem item) {}
	public virtual void RemoveAt(int index) {}
	public virtual void RemoveByKey(string key) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public ListViewItem Item { get{} set{} }
	public ListViewItem Item { get{} }
}

