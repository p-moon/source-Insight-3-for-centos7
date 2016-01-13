public class ToolStripRenderEventArgs : System.EventArgs
{

	// Constructors
	public ToolStripRenderEventArgs(System.Drawing.Graphics g, ToolStrip toolStrip) {}
	public ToolStripRenderEventArgs(System.Drawing.Graphics g, ToolStrip toolStrip, System.Drawing.Rectangle affectedBounds, System.Drawing.Color backColor) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Rectangle AffectedBounds { get{} }
	public System.Drawing.Color BackColor { get{} }
	public System.Drawing.Graphics Graphics { get{} }
	public ToolStrip ToolStrip { get{} }
	public System.Drawing.Rectangle ConnectedArea { get{} }
}

