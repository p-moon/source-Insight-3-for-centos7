public class ToolStripArrowRenderEventArgs : System.EventArgs
{

	// Constructors
	public ToolStripArrowRenderEventArgs(System.Drawing.Graphics g, ToolStripItem toolStripItem, System.Drawing.Rectangle arrowRectangle, System.Drawing.Color arrowColor, ArrowDirection arrowDirection) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Rectangle ArrowRectangle { get{} set{} }
	public System.Drawing.Color ArrowColor { get{} set{} }
	public ArrowDirection Direction { get{} set{} }
	public System.Drawing.Graphics Graphics { get{} }
	public ToolStripItem Item { get{} }
}

