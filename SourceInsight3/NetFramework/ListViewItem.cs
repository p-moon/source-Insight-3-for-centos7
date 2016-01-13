public class ListViewItem : System.ICloneable, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public ListViewItem() {}
	public ListViewItem(string text) {}
	public ListViewItem(string text, int imageIndex) {}
	public ListViewItem(string[] items) {}
	public ListViewItem(string[] items, int imageIndex) {}
	public ListViewItem(string[] items, int imageIndex, System.Drawing.Color foreColor, System.Drawing.Color backColor, System.Drawing.Font font) {}
	public ListViewItem(ListViewSubItem[] subItems, int imageIndex) {}
	public ListViewItem(ListViewGroup group) {}
	public ListViewItem(string text, ListViewGroup group) {}
	public ListViewItem(string text, int imageIndex, ListViewGroup group) {}
	public ListViewItem(string[] items, ListViewGroup group) {}
	public ListViewItem(string[] items, int imageIndex, ListViewGroup group) {}
	public ListViewItem(string[] items, int imageIndex, System.Drawing.Color foreColor, System.Drawing.Color backColor, System.Drawing.Font font, ListViewGroup group) {}
	public ListViewItem(ListViewSubItem[] subItems, int imageIndex, ListViewGroup group) {}
	public ListViewItem(string text, string imageKey) {}
	public ListViewItem(string[] items, string imageKey) {}
	public ListViewItem(string[] items, string imageKey, System.Drawing.Color foreColor, System.Drawing.Color backColor, System.Drawing.Font font) {}
	public ListViewItem(ListViewSubItem[] subItems, string imageKey) {}
	public ListViewItem(string text, string imageKey, ListViewGroup group) {}
	public ListViewItem(string[] items, string imageKey, ListViewGroup group) {}
	public ListViewItem(string[] items, string imageKey, System.Drawing.Color foreColor, System.Drawing.Color backColor, System.Drawing.Font font, ListViewGroup group) {}
	public ListViewItem(ListViewSubItem[] subItems, string imageKey, ListViewGroup group) {}

	// Methods
	public void BeginEdit() {}
	public virtual object Clone() {}
	public virtual void EnsureVisible() {}
	public ListViewItem FindNearestItem(SearchDirectionHint searchDirection) {}
	public System.Drawing.Rectangle GetBounds(ItemBoundsPortion portion) {}
	public ListViewSubItem GetSubItemAt(int x, int y) {}
	public virtual void Remove() {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Color BackColor { get{} set{} }
	public System.Drawing.Rectangle Bounds { get{} }
	public bool Checked { get{} set{} }
	public bool Focused { get{} set{} }
	public System.Drawing.Font Font { get{} set{} }
	public System.Drawing.Color ForeColor { get{} set{} }
	public ListViewGroup Group { get{} set{} }
	public int ImageIndex { get{} set{} }
	public string ImageKey { get{} set{} }
	public ImageList ImageList { get{} }
	public int IndentCount { get{} set{} }
	public int Index { get{} }
	public ListView ListView { get{} }
	public string Name { get{} set{} }
	public System.Drawing.Point Position { get{} set{} }
	public bool Selected { get{} set{} }
	public int StateImageIndex { get{} set{} }
	public ListViewSubItemCollection SubItems { get{} }
	public object Tag { get{} set{} }
	public string Text { get{} set{} }
	public string ToolTipText { get{} set{} }
	public bool UseItemStyleForSubItems { get{} set{} }
}

