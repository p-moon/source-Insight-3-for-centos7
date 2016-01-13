public class DataGridViewCellParsingEventArgs : ConvertEventArgs
{

	// Constructors
	public DataGridViewCellParsingEventArgs(int rowIndex, int columnIndex, object value, Type desiredType, DataGridViewCellStyle inheritedCellStyle) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int RowIndex { get{} }
	public int ColumnIndex { get{} }
	public DataGridViewCellStyle InheritedCellStyle { get{} set{} }
	public bool ParsingApplied { get{} set{} }
	public object Value { get{} set{} }
	public Type DesiredType { get{} }
}

