public class ToolStripItemRenderEventArgs : System.EventArgs
{

	// Constructors
	public ToolStripItemRenderEventArgs(System.Drawing.Graphics g, ToolStripItem item) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Graphics Graphics { get{} }
	public ToolStripItem Item { get{} }
	public ToolStrip ToolStrip { get{} }
}

