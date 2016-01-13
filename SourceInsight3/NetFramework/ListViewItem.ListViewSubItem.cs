public class ListViewSubItem
{

	// Constructors
	public ListViewSubItem() {}
	public ListViewSubItem(ListViewItem owner, string text) {}
	public ListViewSubItem(ListViewItem owner, string text, System.Drawing.Color foreColor, System.Drawing.Color backColor, System.Drawing.Font font) {}

	// Methods
	public void ResetStyle() {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Color BackColor { get{} set{} }
	public System.Drawing.Rectangle Bounds { get{} }
	public System.Drawing.Font Font { get{} set{} }
	public System.Drawing.Color ForeColor { get{} set{} }
	public object Tag { get{} set{} }
	public string Text { get{} set{} }
	public string Name { get{} set{} }
}

