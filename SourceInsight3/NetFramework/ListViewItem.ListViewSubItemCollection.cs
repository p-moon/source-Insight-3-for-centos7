public class ListViewSubItemCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ListViewSubItemCollection(ListViewItem owner) {}

	// Methods
	public ListViewSubItem Add(ListViewSubItem item) {}
	public ListViewSubItem Add(string text) {}
	public ListViewSubItem Add(string text, System.Drawing.Color foreColor, System.Drawing.Color backColor, System.Drawing.Font font) {}
	public void AddRange(ListViewSubItem[] items) {}
	public void AddRange(string[] items) {}
	public void AddRange(string[] items, System.Drawing.Color foreColor, System.Drawing.Color backColor, System.Drawing.Font font) {}
	public virtual void Clear() {}
	public bool Contains(ListViewSubItem subItem) {}
	public virtual bool ContainsKey(string key) {}
	public int IndexOf(ListViewSubItem subItem) {}
	public virtual int IndexOfKey(string key) {}
	public void Insert(int index, ListViewSubItem item) {}
	public void Remove(ListViewSubItem item) {}
	public virtual void RemoveAt(int index) {}
	public virtual void RemoveByKey(string key) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public ListViewSubItem Item { get{} set{} }
	public ListViewSubItem Item { get{} }
}

