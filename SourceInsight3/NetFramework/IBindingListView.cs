public interface IBindingListView : IBindingList, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public abstract virtual void ApplySort(ListSortDescriptionCollection sorts) {}
	public abstract virtual void RemoveFilter() {}

	// Properties
	public string Filter { get{} set{} }
	public ListSortDescriptionCollection SortDescriptions { get{} }
	public bool SupportsAdvancedSorting { get{} }
	public bool SupportsFiltering { get{} }
}

