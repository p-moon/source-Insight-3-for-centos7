public class TableLayoutCellPaintEventArgs : PaintEventArgs, System.IDisposable
{

	// Constructors
	public TableLayoutCellPaintEventArgs(System.Drawing.Graphics g, System.Drawing.Rectangle clipRectangle, System.Drawing.Rectangle cellBounds, int column, int row) {}

	// Methods
	public virtual void Dispose() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Rectangle CellBounds { get{} }
	public int Row { get{} }
	public int Column { get{} }
	public System.Drawing.Rectangle ClipRectangle { get{} }
	public System.Drawing.Graphics Graphics { get{} }
}

