public class DrawListViewItemEventArgs : System.EventArgs
{

	// Constructors
	public DrawListViewItemEventArgs(System.Drawing.Graphics graphics, ListViewItem item, System.Drawing.Rectangle bounds, int itemIndex, ListViewItemStates state) {}

	// Methods
	public void DrawBackground() {}
	public void DrawFocusRectangle() {}
	public void DrawText() {}
	public void DrawText(TextFormatFlags flags) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool DrawDefault { get{} set{} }
	public System.Drawing.Graphics Graphics { get{} }
	public ListViewItem Item { get{} }
	public System.Drawing.Rectangle Bounds { get{} }
	public int ItemIndex { get{} }
	public ListViewItemStates State { get{} }
}

