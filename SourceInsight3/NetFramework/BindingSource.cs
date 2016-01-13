public class BindingSource : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable, System.ComponentModel.IBindingListView, System.ComponentModel.IBindingList, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, System.ComponentModel.ITypedList, System.ComponentModel.ICancelAddNew, System.ComponentModel.ISupportInitializeNotification, System.ComponentModel.ISupportInitialize, ICurrencyManagerProvider
{

	// Constructors
	public BindingSource() {}
	public BindingSource(object dataSource, string dataMember) {}
	public BindingSource(System.ComponentModel.IContainer container) {}

	// Methods
	public virtual CurrencyManager GetRelatedCurrencyManager(string dataMember) {}
	public void CancelEdit() {}
	public void EndEdit() {}
	public int Find(string propertyName, object key) {}
	public void MoveFirst() {}
	public void MoveLast() {}
	public void MoveNext() {}
	public void MovePrevious() {}
	public void RemoveCurrent() {}
	public virtual void ResetAllowNew() {}
	public void ResetBindings(bool metadataChanged) {}
	public void ResetCurrentItem() {}
	public void ResetItem(int itemIndex) {}
	public void ResumeBinding() {}
	public void SuspendBinding() {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual void CopyTo(System.Array arr, int index) {}
	public virtual int Add(object value) {}
	public virtual void Clear() {}
	public virtual bool Contains(object value) {}
	public virtual int IndexOf(object value) {}
	public virtual void Insert(int index, object value) {}
	public virtual void Remove(object value) {}
	public virtual void RemoveAt(int index) {}
	public virtual string GetListName(System.ComponentModel.PropertyDescriptor[] listAccessors) {}
	public virtual System.ComponentModel.PropertyDescriptorCollection GetItemProperties(System.ComponentModel.PropertyDescriptor[] listAccessors) {}
	public virtual object AddNew() {}
	public virtual void ApplySort(System.ComponentModel.PropertyDescriptor property, System.ComponentModel.ListSortDirection sort) {}
	public virtual int Find(System.ComponentModel.PropertyDescriptor prop, object key) {}
	public virtual void RemoveSort() {}
	public virtual void ApplySort(System.ComponentModel.ListSortDescriptionCollection sorts) {}
	public virtual void RemoveFilter() {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CurrencyManager CurrencyManager { get{} }
	public object Current { get{} }
	public string DataMember { get{} set{} }
	public object DataSource { get{} set{} }
	public bool IsBindingSuspended { get{} }
	public System.Collections.IList List { get{} }
	public int Position { get{} set{} }
	public bool RaiseListChangedEvents { get{} set{} }
	public string Sort { get{} set{} }
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
	public object Item { get{} set{} }
	public bool IsFixedSize { get{} }
	public bool IsReadOnly { get{} }
	public bool AllowEdit { get{} }
	public bool AllowNew { get{} set{} }
	public bool AllowRemove { get{} }
	public bool SupportsChangeNotification { get{} }
	public bool SupportsSearching { get{} }
	public bool SupportsSorting { get{} }
	public bool IsSorted { get{} }
	public System.ComponentModel.PropertyDescriptor SortProperty { get{} }
	public System.ComponentModel.ListSortDirection SortDirection { get{} }
	public System.ComponentModel.ListSortDescriptionCollection SortDescriptions { get{} }
	public string Filter { get{} set{} }
	public bool SupportsAdvancedSorting { get{} }
	public bool SupportsFiltering { get{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.ComponentModel.AddingNewEventHandler AddingNew;
	public event System.Windows.Forms.BindingCompleteEventHandler BindingComplete;
	public event System.Windows.Forms.BindingManagerDataErrorEventHandler DataError;
	public event System.EventHandler DataSourceChanged;
	public event System.EventHandler DataMemberChanged;
	public event System.EventHandler CurrentChanged;
	public event System.EventHandler CurrentItemChanged;
	public event System.ComponentModel.ListChangedEventHandler ListChanged;
	public event System.EventHandler PositionChanged;
	public event System.EventHandler Disposed;
}

