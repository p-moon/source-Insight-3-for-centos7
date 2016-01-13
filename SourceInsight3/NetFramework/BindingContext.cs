public class BindingContext : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public BindingContext() {}

	// Methods
	public bool Contains(object dataSource) {}
	public bool Contains(object dataSource, string dataMember) {}
	public static void UpdateBinding(BindingContext newBindingContext, Binding binding) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsReadOnly { get{} }
	public BindingManagerBase Item { get{} }
	public BindingManagerBase Item { get{} }

	// Events
	public event System.ComponentModel.CollectionChangeEventHandler CollectionChanged;
}

