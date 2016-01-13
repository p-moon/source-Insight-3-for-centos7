public class BindingsCollection : BaseCollection, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
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
	public int Count { get{} }
	public Binding Item { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }

	// Events
	public event System.ComponentModel.CollectionChangeEventHandler CollectionChanging;
	public event System.ComponentModel.CollectionChangeEventHandler CollectionChanged;
}

