public class ListItemCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, System.Web.UI.IStateManager
{

	// Constructors
	public ListItemCollection() {}

	// Methods
	public void Add(string item) {}
	public void Add(ListItem item) {}
	public void AddRange(ListItem[] items) {}
	public virtual void Clear() {}
	public bool Contains(ListItem item) {}
	public virtual void CopyTo(System.Array array, int index) {}
	public ListItem FindByText(string text) {}
	public ListItem FindByValue(string value) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public int IndexOf(ListItem item) {}
	public void Insert(int index, string item) {}
	public void Insert(int index, ListItem item) {}
	public virtual void RemoveAt(int index) {}
	public void Remove(string item) {}
	public void Remove(ListItem item) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ListItem Item { get{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}

