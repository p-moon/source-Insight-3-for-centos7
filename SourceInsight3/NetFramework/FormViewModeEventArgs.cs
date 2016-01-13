public class FormViewModeEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public FormViewModeEventArgs(FormViewMode mode, bool cancelingEdit) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool CancelingEdit { get{} }
	public FormViewMode NewMode { get{} set{} }
	public bool Cancel { get{} set{} }
}

