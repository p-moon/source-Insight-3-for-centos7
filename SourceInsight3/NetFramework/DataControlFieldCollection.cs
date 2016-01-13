public class DataControlFieldCollection : System.Web.UI.StateManagedCollection, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, System.Web.UI.IStateManager
{

	// Constructors
	public DataControlFieldCollection() {}

	// Methods
	public void Add(DataControlField field) {}
	public DataControlFieldCollection CloneFields() {}
	public bool Contains(DataControlField field) {}
	public void CopyTo(DataControlField[] array, int index) {}
	public int IndexOf(DataControlField field) {}
	public void Insert(int index, DataControlField field) {}
	public void RemoveAt(int index) {}
	public void Remove(DataControlField field) {}
	public void Clear() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public System.Collections.IEnumerator GetEnumerator() {}
	public void SetDirty() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DataControlField Item { get{} }
	public int Count { get{} }

	// Events
	public event System.EventHandler FieldsChanged;
}

