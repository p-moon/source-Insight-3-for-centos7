public class ToolStripItemImageRenderEventArgs : ToolStripItemRenderEventArgs
{

	// Constructors
	public ToolStripItemImageRenderEventArgs(System.Drawing.Graphics g, ToolStripItem item, System.Drawing.Rectangle imageRectangle) {}
	public ToolStripItemImageRenderEventArgs(System.Drawing.Graphics g, ToolStripItem item, System.Drawing.Image image, System.Drawing.Rectangle imageRectangle) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Image Image { get{} }
	public System.Drawing.Rectangle ImageRectangle { get{} }
	public System.Drawing.Graphics Graphics { get{} }
	public ToolStripItem Item { get{} }
	public ToolStrip ToolStrip { get{} }
}

