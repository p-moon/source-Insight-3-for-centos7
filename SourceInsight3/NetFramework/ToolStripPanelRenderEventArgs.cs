public class ToolStripPanelRenderEventArgs : System.EventArgs
{

	// Constructors
	public ToolStripPanelRenderEventArgs(System.Drawing.Graphics g, ToolStripPanel toolStripPanel) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Graphics Graphics { get{} }
	public ToolStripPanel ToolStripPanel { get{} }
	public bool Handled { get{} set{} }
}

