public class DrawListViewColumnHeaderEventArgs : System.EventArgs
{

	// Constructors
	public DrawListViewColumnHeaderEventArgs(System.Drawing.Graphics graphics, System.Drawing.Rectangle bounds, int columnIndex, ColumnHeader header, ListViewItemStates state, System.Drawing.Color foreColor, System.Drawing.Color backColor, System.Drawing.Font font) {}

	// Methods
	public void DrawBackground() {}
	public void DrawText() {}
	public void DrawText(TextFormatFlags flags) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool DrawDefault { get{} set{} }
	public System.Drawing.Graphics Graphics { get{} }
	public System.Drawing.Rectangle Bounds { get{} }
	public int ColumnIndex { get{} }
	public ColumnHeader Header { get{} }
	public ListViewItemStates State { get{} }
	public System.Drawing.Color ForeColor { get{} }
	public System.Drawing.Color BackColor { get{} }
	public System.Drawing.Font Font { get{} }
}

