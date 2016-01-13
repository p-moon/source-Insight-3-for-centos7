public class DataGridViewCellPaintingEventArgs : System.ComponentModel.HandledEventArgs
{

	// Constructors
	public DataGridViewCellPaintingEventArgs(DataGridView dataGridView, System.Drawing.Graphics graphics, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds, int rowIndex, int columnIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts) {}

	// Methods
	public void Paint(System.Drawing.Rectangle clipBounds, DataGridViewPaintParts paintParts) {}
	public void PaintBackground(System.Drawing.Rectangle clipBounds, bool cellsPaintSelectionBackground) {}
	public void PaintContent(System.Drawing.Rectangle clipBounds) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DataGridViewAdvancedBorderStyle AdvancedBorderStyle { get{} }
	public System.Drawing.Rectangle CellBounds { get{} }
	public DataGridViewCellStyle CellStyle { get{} }
	public System.Drawing.Rectangle ClipBounds { get{} }
	public int ColumnIndex { get{} }
	public string ErrorText { get{} }
	public object FormattedValue { get{} }
	public System.Drawing.Graphics Graphics { get{} }
	public DataGridViewPaintParts PaintParts { get{} }
	public int RowIndex { get{} }
	public DataGridViewElementStates State { get{} }
	public object Value { get{} }
	public bool Handled { get{} set{} }
}

