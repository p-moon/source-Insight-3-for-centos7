public class ToolStripItemTextRenderEventArgs : ToolStripItemRenderEventArgs
{

	// Constructors
	public ToolStripItemTextRenderEventArgs(System.Drawing.Graphics g, ToolStripItem item, string text, System.Drawing.Rectangle textRectangle, System.Drawing.Color textColor, System.Drawing.Font textFont, TextFormatFlags format) {}
	public ToolStripItemTextRenderEventArgs(System.Drawing.Graphics g, ToolStripItem item, string text, System.Drawing.Rectangle textRectangle, System.Drawing.Color textColor, System.Drawing.Font textFont, System.Drawing.ContentAlignment textAlign) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Text { get{} set{} }
	public System.Drawing.Color TextColor { get{} set{} }
	public System.Drawing.Font TextFont { get{} set{} }
	public System.Drawing.Rectangle TextRectangle { get{} set{} }
	public TextFormatFlags TextFormat { get{} set{} }
	public ToolStripTextDirection TextDirection { get{} set{} }
	public System.Drawing.Graphics Graphics { get{} }
	public ToolStripItem Item { get{} }
	public ToolStrip ToolStrip { get{} }
}

