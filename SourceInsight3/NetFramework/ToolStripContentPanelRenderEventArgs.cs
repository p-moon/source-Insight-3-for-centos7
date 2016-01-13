public class ToolStripContentPanelRenderEventArgs : System.EventArgs
{

	// Constructors
	public ToolStripContentPanelRenderEventArgs(System.Drawing.Graphics g, ToolStripContentPanel contentPanel) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Graphics Graphics { get{} }
	public bool Handled { get{} set{} }
	public ToolStripContentPanel ToolStripContentPanel { get{} }
}

