public class PagedDataSource : System.Collections.ICollection, System.Collections.IEnumerable, System.ComponentModel.ITypedList
{

	// Constructors
	public PagedDataSource() {}

	// Methods
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual System.ComponentModel.PropertyDescriptorCollection GetItemProperties(System.ComponentModel.PropertyDescriptor[] listAccessors) {}
	public virtual string GetListName(System.ComponentModel.PropertyDescriptor[] listAccessors) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool AllowCustomPaging { get{} set{} }
	public bool AllowPaging { get{} set{} }
	public bool AllowServerPaging { get{} set{} }
	public int Count { get{} }
	public int CurrentPageIndex { get{} set{} }
	public System.Collections.IEnumerable DataSource { get{} set{} }
	public int DataSourceCount { get{} }
	public int FirstIndexInPage { get{} }
	public bool IsCustomPagingEnabled { get{} }
	public bool IsFirstPage { get{} }
	public bool IsLastPage { get{} }
	public bool IsPagingEnabled { get{} }
	public bool IsReadOnly { get{} }
	public bool IsServerPagingEnabled { get{} }
	public bool IsSynchronized { get{} }
	public int PageCount { get{} }
	public int PageSize { get{} set{} }
	public object SyncRoot { get{} }
	public int VirtualCount { get{} set{} }
}

