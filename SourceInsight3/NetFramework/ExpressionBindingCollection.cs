public class ExpressionBindingCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ExpressionBindingCollection() {}

	// Methods
	public void Add(ExpressionBinding binding) {}
	public bool Contains(string propName) {}
	public void Clear() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public void CopyTo(ExpressionBinding[] array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void Remove(string propertyName) {}
	public void Remove(ExpressionBinding binding) {}
	public void Remove(string propertyName, bool addToRemovedList) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
	public System.Collections.ICollection RemovedBindings { get{} }
	public object SyncRoot { get{} }
	public ExpressionBinding Item { get{} }

	// Events
	public event System.EventHandler Changed;
}

