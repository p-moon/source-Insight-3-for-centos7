public class DataGridViewRowPrePaintEventArgs : System.ComponentModel.HandledEventArgs
{

	// Constructors
	public DataGridViewRowPrePaintEventArgs(DataGridView dataGridView, System.Drawing.Graphics graphics, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle rowBounds, int rowIndex, DataGridViewElementStates rowState, string errorText, DataGridViewCellStyle inheritedRowStyle, bool isFirstDisplayedRow, bool isLastVisibleRow) {}

	// Methods
	public void DrawFocus(System.Drawing.Rectangle bounds, bool cellsPaintSelectionBackground) {}
	public void PaintCells(System.Drawing.Rectangle clipBounds, DataGridViewPaintParts paintParts) {}
	public void PaintCellsBackground(System.Drawing.Rectangle clipBounds, bool cellsPaintSelectionBackground) {}
	public void PaintCellsContent(System.Drawing.Rectangle clipBounds) {}
	public void PaintHeader(bool paintSelectionBackground) {}
	public void PaintHeader(DataGridViewPaintParts paintParts) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Rectangle ClipBounds { get{} set{} }
	public string ErrorText { get{} }
	public System.Drawing.Graphics Graphics { get{} }
	public DataGridViewCellStyle InheritedRowStyle { get{} }
	public bool IsFirstDisplayedRow { get{} }
	public bool IsLastVisibleRow { get{} }
	public DataGridViewPaintParts PaintParts { get{} set{} }
	public System.Drawing.Rectangle RowBounds { get{} }
	public int RowIndex { get{} }
	public DataGridViewElementStates State { get{} }
	public bool Handled { get{} set{} }
}

