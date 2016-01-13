public class DataGridViewSortCompareEventArgs : System.ComponentModel.HandledEventArgs
{

	// Constructors
	public DataGridViewSortCompareEventArgs(DataGridViewColumn dataGridViewColumn, object cellValue1, object cellValue2, int rowIndex1, int rowIndex2) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object CellValue1 { get{} }
	public object CellValue2 { get{} }
	public DataGridViewColumn Column { get{} }
	public int RowIndex1 { get{} }
	public int RowIndex2 { get{} }
	public int SortResult { get{} set{} }
	public bool Handled { get{} set{} }
}

