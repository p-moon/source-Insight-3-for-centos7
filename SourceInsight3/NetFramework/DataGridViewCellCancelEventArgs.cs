public class DataGridViewCellCancelEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public DataGridViewCellCancelEventArgs(int columnIndex, int rowIndex) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int ColumnIndex { get{} }
	public int RowIndex { get{} }
	public bool Cancel { get{} set{} }
}

