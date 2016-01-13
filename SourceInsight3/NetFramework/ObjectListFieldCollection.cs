public class ObjectListFieldCollection : ArrayListCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable, IObjectListFieldCollection, System.Web.UI.IStateManager
{

	// Methods
	public virtual ObjectListField[] GetAll() {}
	public void SetAll(ObjectListField[] value) {}
	public void Add(ObjectListField field) {}
	public void AddAt(int index, ObjectListField field) {}
	public void Clear() {}
	public void RemoveAt(int index) {}
	public void Remove(ObjectListField field) {}
	public virtual int IndexOf(ObjectListField field) {}
	public virtual int IndexOf(string fieldIDOrName) {}
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ObjectListField Item { get{} }
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}

