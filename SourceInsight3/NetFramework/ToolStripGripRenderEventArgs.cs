public class ToolStripGripRenderEventArgs : ToolStripRenderEventArgs
{

	// Constructors
	public ToolStripGripRenderEventArgs(System.Drawing.Graphics g, ToolStrip toolStrip) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Rectangle GripBounds { get{} }
	public ToolStripGripDisplayStyle GripDisplayStyle { get{} }
	public ToolStripGripStyle GripStyle { get{} }
	public System.Drawing.Rectangle AffectedBounds { get{} }
	public System.Drawing.Color BackColor { get{} }
	public System.Drawing.Graphics Graphics { get{} }
	public ToolStrip ToolStrip { get{} }
	public System.Drawing.Rectangle ConnectedArea { get{} }
}

