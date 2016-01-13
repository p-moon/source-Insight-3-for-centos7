public class ToolStripItemEventArgs : System.EventArgs
{

	// Constructors
	public ToolStripItemEventArgs(ToolStripItem item) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ToolStripItem Item { get{} }
}

