public class ToolStripItemClickedEventArgs : System.EventArgs
{

	// Constructors
	public ToolStripItemClickedEventArgs(ToolStripItem clickedItem) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ToolStripItem ClickedItem { get{} }
}

