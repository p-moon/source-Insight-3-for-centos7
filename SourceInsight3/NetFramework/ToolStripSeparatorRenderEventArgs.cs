public class ToolStripSeparatorRenderEventArgs : ToolStripItemRenderEventArgs
{

	// Constructors
	public ToolStripSeparatorRenderEventArgs(System.Drawing.Graphics g, ToolStripSeparator separator, bool vertical) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Vertical { get{} }
	public System.Drawing.Graphics Graphics { get{} }
	public ToolStripItem Item { get{} }
	public ToolStrip ToolStrip { get{} }
}

