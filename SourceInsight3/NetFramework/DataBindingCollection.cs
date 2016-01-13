public class DataBindingCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public DataBindingCollection() {}

	// Methods
	public void Add(DataBinding binding) {}
	public bool Contains(string propertyName) {}
	public void Clear() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void Remove(string propertyName) {}
	public void Remove(DataBinding binding) {}
	public void Remove(string propertyName, bool addToRemovedList) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
	public string[] RemovedBindings { get{} }
	public object SyncRoot { get{} }
	public DataBinding Item { get{} }

	// Events
	public event System.EventHandler Changed;
}

