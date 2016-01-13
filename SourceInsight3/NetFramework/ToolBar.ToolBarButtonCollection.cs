public class ToolBarButtonCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ToolBarButtonCollection(ToolBar owner) {}

	// Methods
	public int Add(ToolBarButton button) {}
	public int Add(string text) {}
	public void AddRange(ToolBarButton[] buttons) {}
	public virtual void Clear() {}
	public bool Contains(ToolBarButton button) {}
	public virtual bool ContainsKey(string key) {}
	public int IndexOf(ToolBarButton button) {}
	public virtual int IndexOfKey(string key) {}
	public void Insert(int index, ToolBarButton button) {}
	public virtual void RemoveAt(int index) {}
	public virtual void RemoveByKey(string key) {}
	public void Remove(ToolBarButton button) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ToolBarButton Item { get{} set{} }
	public ToolBarButton Item { get{} }
	public int Count { get{} }
	public bool IsReadOnly { get{} }
}

