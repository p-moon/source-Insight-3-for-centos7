public class DrawToolTipEventArgs : System.EventArgs
{

	// Constructors
	public DrawToolTipEventArgs(System.Drawing.Graphics graphics, IWin32Window associatedWindow, Control associatedControl, System.Drawing.Rectangle bounds, string toolTipText, System.Drawing.Color backColor, System.Drawing.Color foreColor, System.Drawing.Font font) {}

	// Methods
	public void DrawBackground() {}
	public void DrawText() {}
	public void DrawText(TextFormatFlags flags) {}
	public void DrawBorder() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Graphics Graphics { get{} }
	public IWin32Window AssociatedWindow { get{} }
	public Control AssociatedControl { get{} }
	public System.Drawing.Rectangle Bounds { get{} }
	public string ToolTipText { get{} }
	public System.Drawing.Font Font { get{} }
}

