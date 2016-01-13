public class DetailsViewModeEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public DetailsViewModeEventArgs(DetailsViewMode mode, bool cancelingEdit) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool CancelingEdit { get{} }
	public DetailsViewMode NewMode { get{} set{} }
	public bool Cancel { get{} set{} }
}

