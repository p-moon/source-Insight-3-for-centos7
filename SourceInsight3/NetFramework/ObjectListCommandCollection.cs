public class ObjectListCommandCollection : ArrayListCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable, System.Web.UI.IStateManager
{

	// Methods
	public void Clear() {}
	public void Add(ObjectListCommand command) {}
	public void AddAt(int index, ObjectListCommand command) {}
	public void Remove(string s) {}
	public void RemoveAt(int index) {}
	public int IndexOf(string s) {}
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ObjectListCommand Item { get{} }
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}

