public class DataGridViewCellValueEventArgs : System.EventArgs
{

	// Constructors
	public DataGridViewCellValueEventArgs(int columnIndex, int rowIndex) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int ColumnIndex { get{} }
	public int RowIndex { get{} }
	public object Value { get{} set{} }
}

