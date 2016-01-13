public class FormClosingEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public FormClosingEventArgs(CloseReason closeReason, bool cancel) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CloseReason CloseReason { get{} }
	public bool Cancel { get{} set{} }
}

