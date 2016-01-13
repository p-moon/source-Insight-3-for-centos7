public class DataGridViewCellMouseEventArgs : MouseEventArgs
{

	// Constructors
	public DataGridViewCellMouseEventArgs(int columnIndex, int rowIndex, int localX, int localY, MouseEventArgs e) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int ColumnIndex { get{} }
	public int RowIndex { get{} }
	public MouseButtons Button { get{} }
	public int Clicks { get{} }
	public int X { get{} }
	public int Y { get{} }
	public int Delta { get{} }
	public System.Drawing.Point Location { get{} }
}

