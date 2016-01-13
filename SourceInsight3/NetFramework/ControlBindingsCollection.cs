public class ControlBindingsCollection : BindingsCollection, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ControlBindingsCollection(IBindableComponent control) {}

	// Methods
	public void Add(Binding binding) {}
	public Binding Add(string propertyName, object dataSource, string dataMember) {}
	public Binding Add(string propertyName, object dataSource, string dataMember, bool formattingEnabled) {}
	public Binding Add(string propertyName, object dataSource, string dataMember, bool formattingEnabled, DataSourceUpdateMode updateMode) {}
	public Binding Add(string propertyName, object dataSource, string dataMember, bool formattingEnabled, DataSourceUpdateMode updateMode, object nullValue) {}
	public Binding Add(string propertyName, object dataSource, string dataMember, bool formattingEnabled, DataSourceUpdateMode updateMode, object nullValue, string formatString) {}
	public Binding Add(string propertyName, object dataSource, string dataMember, bool formattingEnabled, DataSourceUpdateMode updateMode, object nullValue, string formatString, System.IFormatProvider formatInfo) {}
	public void Clear() {}
	public void Remove(Binding binding) {}
	public void RemoveAt(int index) {}
	public virtual void CopyTo(System.Array ar, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public IBindableComponent BindableComponent { get{} }
	public Control Control { get{} }
	public Binding Item { get{} }
	public DataSourceUpdateMode DefaultDataSourceUpdateMode { get{} set{} }
	public int Count { get{} }
	public Binding Item { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }

	// Events
	public event System.ComponentModel.CollectionChangeEventHandler CollectionChanging;
	public event System.ComponentModel.CollectionChangeEventHandler CollectionChanged;
}

