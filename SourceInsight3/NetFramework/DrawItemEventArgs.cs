public class DrawItemEventArgs : System.EventArgs
{

	// Constructors
	public DrawItemEventArgs(System.Drawing.Graphics graphics, System.Drawing.Font font, System.Drawing.Rectangle rect, int index, DrawItemState state) {}
	public DrawItemEventArgs(System.Drawing.Graphics graphics, System.Drawing.Font font, System.Drawing.Rectangle rect, int index, DrawItemState state, System.Drawing.Color foreColor, System.Drawing.Color backColor) {}

	// Methods
	public virtual void DrawBackground() {}
	public virtual void DrawFocusRectangle() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Color BackColor { get{} }
	public System.Drawing.Rectangle Bounds { get{} }
	public System.Drawing.Font Font { get{} }
	public System.Drawing.Color ForeColor { get{} }
	public System.Drawing.Graphics Graphics { get{} }
	public int Index { get{} }
	public DrawItemState State { get{} }
}

