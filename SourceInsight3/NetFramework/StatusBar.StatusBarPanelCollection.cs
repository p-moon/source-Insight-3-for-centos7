public class StatusBarPanelCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public StatusBarPanelCollection(StatusBar owner) {}

	// Methods
	public virtual StatusBarPanel Add(string text) {}
	public virtual int Add(StatusBarPanel value) {}
	public virtual void AddRange(StatusBarPanel[] panels) {}
	public bool Contains(StatusBarPanel panel) {}
	public virtual bool ContainsKey(string key) {}
	public int IndexOf(StatusBarPanel panel) {}
	public virtual int IndexOfKey(string key) {}
	public virtual void Insert(int index, StatusBarPanel value) {}
	public virtual void Clear() {}
	public virtual void Remove(StatusBarPanel value) {}
	public virtual void RemoveAt(int index) {}
	public virtual void RemoveByKey(string key) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public StatusBarPanel Item { get{} set{} }
	public StatusBarPanel Item { get{} }
	public int Count { get{} }
	public bool IsReadOnly { get{} }
}

