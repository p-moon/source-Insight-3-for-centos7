public class DataGridViewRow : DataGridViewBand, System.ICloneable, System.IDisposable
{

	// Constructors
	public DataGridViewRow() {}

	// Methods
	public virtual DataGridViewAdvancedBorderStyle AdjustRowHeaderBorderStyle(DataGridViewAdvancedBorderStyle dataGridViewAdvancedBorderStyleInput, DataGridViewAdvancedBorderStyle dataGridViewAdvancedBorderStylePlaceholder, bool singleVerticalBorderAdded, bool singleHorizontalBorderAdded, bool isFirstDisplayedRow, bool isLastVisibleRow) {}
	public virtual object Clone() {}
	public void CreateCells(DataGridView dataGridView) {}
	public void CreateCells(DataGridView dataGridView, object[] values) {}
	public ContextMenuStrip GetContextMenuStrip(int rowIndex) {}
	public string GetErrorText(int rowIndex) {}
	public virtual int GetPreferredHeight(int rowIndex, DataGridViewAutoSizeRowMode autoSizeRowMode, bool fixedWidth) {}
	public virtual DataGridViewElementStates GetState(int rowIndex) {}
	public bool SetValues(object[] values) {}
	public virtual string ToString() {}
	public virtual void Dispose() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public AccessibleObject AccessibilityObject { get{} }
	public DataGridViewCellCollection Cells { get{} }
	public ContextMenuStrip ContextMenuStrip { get{} set{} }
	public object DataBoundItem { get{} }
	public DataGridViewCellStyle DefaultCellStyle { get{} set{} }
	public bool Displayed { get{} }
	public int DividerHeight { get{} set{} }
	public string ErrorText { get{} set{} }
	public bool Frozen { get{} set{} }
	public DataGridViewRowHeaderCell HeaderCell { get{} set{} }
	public int Height { get{} set{} }
	public DataGridViewCellStyle InheritedStyle { get{} }
	public bool IsNewRow { get{} }
	public int MinimumHeight { get{} set{} }
	public bool ReadOnly { get{} set{} }
	public DataGridViewTriState Resizable { get{} set{} }
	public bool Selected { get{} set{} }
	public DataGridViewElementStates State { get{} }
	public bool Visible { get{} set{} }
	public Type DefaultHeaderCellType { get{} set{} }
	public bool HasDefaultCellStyle { get{} }
	public int Index { get{} }
	public object Tag { get{} set{} }
	public DataGridView DataGridView { get{} }
}

