public class MobileListItemCollection : ArrayListCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable, System.Web.UI.IStateManager
{

	// Constructors
	public MobileListItemCollection() {}
	public MobileListItemCollection(System.Collections.ArrayList items) {}

	// Methods
	public MobileListItem[] GetAll() {}
	public void SetAll(MobileListItem[] value) {}
	public void Add(MobileListItem item) {}
	public virtual void Add(string item) {}
	public void Clear() {}
	public bool Contains(MobileListItem item) {}
	public int IndexOf(MobileListItem item) {}
	public virtual void Insert(int index, string item) {}
	public void Insert(int index, MobileListItem item) {}
	public void RemoveAt(int index) {}
	public virtual void Remove(string item) {}
	public void Remove(MobileListItem item) {}
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MobileListItem Item { get{} }
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}

