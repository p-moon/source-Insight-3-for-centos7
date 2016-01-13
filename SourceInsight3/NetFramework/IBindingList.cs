public interface IBindingList : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public abstract virtual object AddNew() {}
	public abstract virtual void AddIndex(PropertyDescriptor property) {}
	public abstract virtual void ApplySort(PropertyDescriptor property, ListSortDirection direction) {}
	public abstract virtual int Find(PropertyDescriptor property, object key) {}
	public abstract virtual void RemoveIndex(PropertyDescriptor property) {}
	public abstract virtual void RemoveSort() {}

	// Properties
	public bool AllowNew { get{} }
	public bool AllowEdit { get{} }
	public bool AllowRemove { get{} }
	public bool SupportsChangeNotification { get{} }
	public bool SupportsSearching { get{} }
	public bool SupportsSorting { get{} }
	public bool IsSorted { get{} }
	public PropertyDescriptor SortProperty { get{} }
	public ListSortDirection SortDirection { get{} }

	// Events
	public event System.ComponentModel.ListChangedEventHandler ListChanged;
}

