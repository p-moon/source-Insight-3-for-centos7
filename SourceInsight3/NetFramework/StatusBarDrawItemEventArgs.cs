public class StatusBarDrawItemEventArgs : DrawItemEventArgs
{

	// Constructors
	public StatusBarDrawItemEventArgs(System.Drawing.Graphics g, System.Drawing.Font font, System.Drawing.Rectangle r, int itemId, DrawItemState itemState, StatusBarPanel panel) {}
	public StatusBarDrawItemEventArgs(System.Drawing.Graphics g, System.Drawing.Font font, System.Drawing.Rectangle r, int itemId, DrawItemState itemState, StatusBarPanel panel, System.Drawing.Color foreColor, System.Drawing.Color backColor) {}

	// Methods
	public virtual void DrawBackground() {}
	public virtual void DrawFocusRectangle() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public StatusBarPanel Panel { get{} }
	public System.Drawing.Color BackColor { get{} }
	public System.Drawing.Rectangle Bounds { get{} }
	public System.Drawing.Font Font { get{} }
	public System.Drawing.Color ForeColor { get{} }
	public System.Drawing.Graphics Graphics { get{} }
	public int Index { get{} }
	public DrawItemState State { get{} }
}

