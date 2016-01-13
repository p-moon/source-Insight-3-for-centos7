public class ObjectListItemCollection : ArrayListCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable, System.Web.UI.IStateManager
{

	// Methods
	public ObjectListItem[] GetAll() {}
	public void Clear() {}
	public bool Contains(ObjectListItem item) {}
	public int IndexOf(ObjectListItem item) {}
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ObjectListItem Item { get{} }
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}

