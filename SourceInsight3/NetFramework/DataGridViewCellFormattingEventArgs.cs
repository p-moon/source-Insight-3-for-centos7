public class DataGridViewCellFormattingEventArgs : ConvertEventArgs
{

	// Constructors
	public DataGridViewCellFormattingEventArgs(int columnIndex, int rowIndex, object value, Type desiredType, DataGridViewCellStyle cellStyle) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DataGridViewCellStyle CellStyle { get{} set{} }
	public int ColumnIndex { get{} }
	public bool FormattingApplied { get{} set{} }
	public int RowIndex { get{} }
	public object Value { get{} set{} }
	public Type DesiredType { get{} }
}

