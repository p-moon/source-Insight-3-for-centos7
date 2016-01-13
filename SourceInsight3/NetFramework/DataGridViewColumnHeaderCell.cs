public class DataGridViewColumnHeaderCell : DataGridViewHeaderCell, System.ICloneable, System.IDisposable
{

	// Constructors
	public DataGridViewColumnHeaderCell() {}

	// Methods
	public virtual object Clone() {}
	public virtual ContextMenuStrip GetInheritedContextMenuStrip(int rowIndex) {}
	public virtual DataGridViewCellStyle GetInheritedStyle(DataGridViewCellStyle inheritedCellStyle, int rowIndex, bool includeColors) {}
	public virtual string ToString() {}
	public virtual DataGridViewElementStates GetInheritedState(int rowIndex) {}
	public virtual DataGridViewAdvancedBorderStyle AdjustCellBorderStyle(DataGridViewAdvancedBorderStyle dataGridViewAdvancedBorderStyleInput, DataGridViewAdvancedBorderStyle dataGridViewAdvancedBorderStylePlaceholder, bool singleVerticalBorderAdded, bool singleHorizontalBorderAdded, bool isFirstDisplayedColumn, bool isFirstDisplayedRow) {}
	public virtual void DetachEditingControl() {}
	public virtual void Dispose() {}
	public System.Drawing.Rectangle GetContentBounds(int rowIndex) {}
	public object GetEditedFormattedValue(int rowIndex, DataGridViewDataErrorContexts context) {}
	public virtual void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle) {}
	public virtual bool KeyEntersEditMode(KeyEventArgs e) {}
	public virtual object ParseFormattedValue(object formattedValue, DataGridViewCellStyle cellStyle, System.ComponentModel.TypeConverter formattedValueTypeConverter, System.ComponentModel.TypeConverter valueTypeConverter) {}
	public virtual void PositionEditingControl(bool setLocation, bool setSize, System.Drawing.Rectangle cellBounds, System.Drawing.Rectangle cellClip, DataGridViewCellStyle cellStyle, bool singleVerticalBorderAdded, bool singleHorizontalBorderAdded, bool isFirstDisplayedColumn, bool isFirstDisplayedRow) {}
	public virtual System.Drawing.Rectangle PositionEditingPanel(System.Drawing.Rectangle cellBounds, System.Drawing.Rectangle cellClip, DataGridViewCellStyle cellStyle, bool singleVerticalBorderAdded, bool singleHorizontalBorderAdded, bool isFirstDisplayedColumn, bool isFirstDisplayedRow) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SortOrder SortGlyphDirection { get{} set{} }
	public bool Displayed { get{} }
	public Type FormattedValueType { get{} }
	public bool Frozen { get{} }
	public bool ReadOnly { get{} set{} }
	public bool Resizable { get{} }
	public bool Selected { get{} set{} }
	public Type ValueType { get{} set{} }
	public bool Visible { get{} }
	public AccessibleObject AccessibilityObject { get{} }
	public int ColumnIndex { get{} }
	public System.Drawing.Rectangle ContentBounds { get{} }
	public ContextMenuStrip ContextMenuStrip { get{} set{} }
	public object DefaultNewRowValue { get{} }
	public object EditedFormattedValue { get{} }
	public Type EditType { get{} }
	public System.Drawing.Rectangle ErrorIconBounds { get{} }
	public string ErrorText { get{} set{} }
	public object FormattedValue { get{} }
	public bool HasStyle { get{} }
	public DataGridViewElementStates InheritedState { get{} }
	public DataGridViewCellStyle InheritedStyle { get{} }
	public bool IsInEditMode { get{} }
	public DataGridViewColumn OwningColumn { get{} }
	public DataGridViewRow OwningRow { get{} }
	public System.Drawing.Size PreferredSize { get{} }
	public int RowIndex { get{} }
	public System.Drawing.Size Size { get{} }
	public DataGridViewCellStyle Style { get{} set{} }
	public object Tag { get{} set{} }
	public string ToolTipText { get{} set{} }
	public object Value { get{} set{} }
	public DataGridViewElementStates State { get{} }
	public DataGridView DataGridView { get{} }
}

