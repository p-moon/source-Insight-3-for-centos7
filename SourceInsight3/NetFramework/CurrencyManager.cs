public class CurrencyManager : BindingManagerBase
{

	// Methods
	public virtual void AddNew() {}
	public virtual void CancelCurrentEdit() {}
	public virtual void RemoveAt(int index) {}
	public virtual void EndCurrentEdit() {}
	public virtual System.ComponentModel.PropertyDescriptorCollection GetItemProperties() {}
	public void Refresh() {}
	public virtual void ResumeBinding() {}
	public virtual void SuspendBinding() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public object Current { get{} }
	public System.Collections.IList List { get{} }
	public int Position { get{} set{} }
	public BindingsCollection Bindings { get{} }
	public bool IsBindingSuspended { get{} }

	// Events
	public event System.Windows.Forms.ItemChangedEventHandler ItemChanged;
	public event System.ComponentModel.ListChangedEventHandler ListChanged;
	public event System.EventHandler MetaDataChanged;
	public event System.Windows.Forms.BindingCompleteEventHandler BindingComplete;
	public event System.EventHandler CurrentChanged;
	public event System.EventHandler CurrentItemChanged;
	public event System.Windows.Forms.BindingManagerDataErrorEventHandler DataError;
	public event System.EventHandler PositionChanged;
}

