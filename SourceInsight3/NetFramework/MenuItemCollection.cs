public class MenuItemCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Web.UI.IStateManager
{

	// Constructors
	public MenuItemCollection() {}
	public MenuItemCollection(MenuItem owner) {}

	// Methods
	public void Add(MenuItem child) {}
	public void AddAt(int index, MenuItem child) {}
	public void Clear() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public void CopyTo(MenuItem[] array, int index) {}
	public bool Contains(MenuItem c) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public int IndexOf(MenuItem value) {}
	public void Remove(MenuItem value) {}
	public void RemoveAt(int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
	public MenuItem Item { get{} }
}

