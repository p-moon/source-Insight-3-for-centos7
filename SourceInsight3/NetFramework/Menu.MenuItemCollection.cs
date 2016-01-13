public class MenuItemCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public MenuItemCollection(Menu owner) {}

	// Methods
	public virtual MenuItem Add(string caption) {}
	public virtual MenuItem Add(string caption, System.EventHandler onClick) {}
	public virtual MenuItem Add(string caption, MenuItem[] items) {}
	public virtual int Add(MenuItem item) {}
	public virtual int Add(int index, MenuItem item) {}
	public virtual void AddRange(MenuItem[] items) {}
	public bool Contains(MenuItem value) {}
	public virtual bool ContainsKey(string key) {}
	public MenuItem[] Find(string key, bool searchAllChildren) {}
	public int IndexOf(MenuItem value) {}
	public virtual int IndexOfKey(string key) {}
	public virtual void Clear() {}
	public virtual void CopyTo(System.Array dest, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual void RemoveAt(int index) {}
	public virtual void RemoveByKey(string key) {}
	public virtual void Remove(MenuItem item) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MenuItem Item { get{} }
	public MenuItem Item { get{} }
	public int Count { get{} }
	public bool IsReadOnly { get{} }
}

