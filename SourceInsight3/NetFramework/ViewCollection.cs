public class ViewCollection : System.Web.UI.ControlCollection, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ViewCollection(System.Web.UI.Control owner) {}

	// Methods
	public virtual void Add(System.Web.UI.Control v) {}
	public virtual void AddAt(int index, System.Web.UI.Control v) {}
	public virtual void Clear() {}
	public virtual bool Contains(System.Web.UI.Control c) {}
	public virtual int IndexOf(System.Web.UI.Control value) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual void RemoveAt(int index) {}
	public virtual void Remove(System.Web.UI.Control value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public View Item { get{} }
	public int Count { get{} }
	public object SyncRoot { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
	public System.Web.UI.Control Item { get{} }
}

