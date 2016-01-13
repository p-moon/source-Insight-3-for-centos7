public class DataGridViewCellContextMenuStripNeededEventArgs : DataGridViewCellEventArgs
{

	// Constructors
	public DataGridViewCellContextMenuStripNeededEventArgs(int columnIndex, int rowIndex) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ContextMenuStrip ContextMenuStrip { get{} set{} }
	public int ColumnIndex { get{} }
	public int RowIndex { get{} }
}

