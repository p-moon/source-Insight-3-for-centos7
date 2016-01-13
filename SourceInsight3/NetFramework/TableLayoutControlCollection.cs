public class TableLayoutControlCollection : ControlCollection, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, System.ICloneable
{

	// Constructors
	public TableLayoutControlCollection(TableLayoutPanel container) {}

	// Methods
	public virtual void Add(Control control, int column, int row) {}
	public virtual bool ContainsKey(string key) {}
	public virtual void Add(Control value) {}
	public virtual void AddRange(Control[] controls) {}
	public bool Contains(Control control) {}
	public Control[] Find(string key, bool searchAllChildren) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public int IndexOf(Control control) {}
	public virtual int IndexOfKey(string key) {}
	public virtual void Remove(Control value) {}
	public virtual void RemoveAt(int index) {}
	public virtual void RemoveByKey(string key) {}
	public virtual void Clear() {}
	public int GetChildIndex(Control child) {}
	public virtual int GetChildIndex(Control child, bool throwException) {}
	public virtual void SetChildIndex(Control child, int newIndex) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public TableLayoutPanel Container { get{} }
	public Control Owner { get{} }
	public Control Item { get{} }
	public Control Item { get{} }
	public bool IsReadOnly { get{} }
	public int Count { get{} }
}

