public class ToolStripDropDownClosingEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public ToolStripDropDownClosingEventArgs(ToolStripDropDownCloseReason reason) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ToolStripDropDownCloseReason CloseReason { get{} }
	public bool Cancel { get{} set{} }
}

