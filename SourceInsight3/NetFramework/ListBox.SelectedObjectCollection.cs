public class SelectedObjectCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public SelectedObjectCollection(ListBox owner) {}

	// Methods
	public virtual bool Contains(object selectedObject) {}
	public virtual int IndexOf(object selectedObject) {}
	public virtual void CopyTo(System.Array destination, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void Clear() {}
	public void Add(object value) {}
	public void Remove(object value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public object Item { get{} set{} }
}

