public class DrawListViewSubItemEventArgs : System.EventArgs
{

	// Constructors
	public DrawListViewSubItemEventArgs(System.Drawing.Graphics graphics, System.Drawing.Rectangle bounds, ListViewItem item, ListViewSubItem subItem, int itemIndex, int columnIndex, ColumnHeader header, ListViewItemStates itemState) {}

	// Methods
	public void DrawBackground() {}
	public void DrawFocusRectangle(System.Drawing.Rectangle bounds) {}
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
	public ListViewItem Item { get{} }
	public ListViewSubItem SubItem { get{} }
	public int ItemIndex { get{} }
	public int ColumnIndex { get{} }
	public ColumnHeader Header { get{} }
	public ListViewItemStates ItemState { get{} }
}

