public class BindingManagerBase
{

	// Constructors
	public BindingManagerBase() {}

	// Methods
	public virtual System.ComponentModel.PropertyDescriptorCollection GetItemProperties() {}
	public abstract virtual void CancelCurrentEdit() {}
	public abstract virtual void EndCurrentEdit() {}
	public abstract virtual void AddNew() {}
	public abstract virtual void RemoveAt(int index) {}
	public abstract virtual void SuspendBinding() {}
	public abstract virtual void ResumeBinding() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public BindingsCollection Bindings { get{} }
	public object Current { get{} }
	public int Position { get{} set{} }
	public bool IsBindingSuspended { get{} }
	public int Count { get{} }

	// Events
	public event System.Windows.Forms.BindingCompleteEventHandler BindingComplete;
	public event System.EventHandler CurrentChanged;
	public event System.EventHandler CurrentItemChanged;
	public event System.Windows.Forms.BindingManagerDataErrorEventHandler DataError;
	public event System.EventHandler PositionChanged;
}

