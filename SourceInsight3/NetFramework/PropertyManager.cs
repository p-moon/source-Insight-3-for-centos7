public class PropertyManager : BindingManagerBase
{

	// Constructors
	public PropertyManager() {}

	// Methods
	public virtual void SuspendBinding() {}
	public virtual void ResumeBinding() {}
	public virtual void CancelCurrentEdit() {}
	public virtual void EndCurrentEdit() {}
	public virtual void AddNew() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.ComponentModel.PropertyDescriptorCollection GetItemProperties() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object Current { get{} }
	public int Position { get{} set{} }
	public int Count { get{} }
	public BindingsCollection Bindings { get{} }
	public bool IsBindingSuspended { get{} }

	// Events
	public event System.Windows.Forms.BindingCompleteEventHandler BindingComplete;
	public event System.EventHandler CurrentChanged;
	public event System.EventHandler CurrentItemChanged;
	public event System.Windows.Forms.BindingManagerDataErrorEventHandler DataError;
	public event System.EventHandler PositionChanged;
}

