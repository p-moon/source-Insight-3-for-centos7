public class BindingList<T> : Collection<T>, IList<T>, ICollection<T>, IEnumerable<T>, System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, IBindingList, ICancelAddNew, IRaiseItemChangedEvents
{

	// Constructors
	public BindingList() {}
	public BindingList(IList<T> list) {}

	// Methods
	public void ResetBindings() {}
	public void ResetItem(int position) {}
	public virtual void CancelNew(int itemIndex) {}
	public virtual void EndNew(int itemIndex) {}
	public T AddNew() {}
	public virtual void Add(T item) {}
	public virtual void Clear() {}
	public virtual void CopyTo(T[] array, int index) {}
	public virtual bool Contains(T item) {}
	public virtual IEnumerator<T> GetEnumerator() {}
	public virtual int IndexOf(T item) {}
	public virtual void Insert(int index, T item) {}
	public virtual bool Remove(T item) {}
	public virtual void RemoveAt(int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool RaiseListChangedEvents { get{} set{} }
	public bool AllowNew { get{} set{} }
	public bool AllowEdit { get{} set{} }
	public bool AllowRemove { get{} set{} }
	public int Count { get{} }
	public T Item { get{} set{} }

	// Events
	public event System.ComponentModel.AddingNewEventHandler AddingNew;
	public event System.ComponentModel.ListChangedEventHandler ListChanged;
}

