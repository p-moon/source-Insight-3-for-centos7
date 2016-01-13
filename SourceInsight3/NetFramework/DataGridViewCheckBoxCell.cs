public class DataGridViewCheckBoxCell : DataGridViewCell, System.ICloneable, System.IDisposable, IDataGridViewEditingCell
{

	// Constructors
	public DataGridViewCheckBoxCell() {}
	public DataGridViewCheckBoxCell(bool threeState) {}

	// Methods
	public virtual object GetEditingCellFormattedValue(DataGridViewDataErrorContexts context) {}
	public virtual void PrepareEditingCellForEdit(bool selectAll) {}
	public virtual object Clone() {}
	public virtual object ParseFormattedValue(object formattedValue, DataGridViewCellStyle cellStyle, System.ComponentModel.TypeConverter formattedValueTypeConverter, System.ComponentModel.TypeConverter valueTypeConverter) {}
	public virtual string ToString() {}
	public virtual DataGridViewAdvancedBorderStyle AdjustCellBorderStyle(DataGridViewAdvancedBorderStyle dataGridViewAdvancedBorderStyleInput, DataGridViewAdvancedBorderStyle dataGridViewAdvancedBorderStylePlaceholder, bool singleVerticalBorderAdded, bool singleHorizontalBorderAdded, bool isFirstDisplayedColumn, bool isFirstDisplayedRow) {}
	public virtual void DetachEditingControl() {}
	public virtual void Dispose() {}
	public System.Drawing.Rectangle GetContentBounds(int rowIndex) {}
	public object GetEditedFormattedValue(int rowIndex, DataGridViewDataErrorContexts context) {}
	public virtual ContextMenuStrip GetInheritedContextMenuStrip(int rowIndex) {}
	public virtual DataGridViewElementStates GetInheritedState(int rowIndex) {}
	public virtual DataGridViewCellStyle GetInheritedStyle(DataGridViewCellStyle inheritedCellStyle, int rowIndex, bool includeColors) {}
	public virtual void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle) {}
	public virtual bool KeyEntersEditMode(KeyEventArgs e) {}
	public virtual void PositionEditingControl(bool setLocation, bool setSize, System.Drawing.Rectangle cellBounds, System.Drawing.Rectangle cellClip, DataGridViewCellStyle cellStyle, bool singleVerticalBorderAdded, bool singleHorizontalBorderAdded, bool isFirstDisplayedColumn, bool isFirstDisplayedRow) {}
	public virtual System.Drawing.Rectangle PositionEditingPanel(System.Drawing.Rectangle cellBounds, System.Drawing.Rectangle cellClip, DataGridViewCellStyle cellStyle, bool singleVerticalBorderAdded, bool singleHorizontalBorderAdded, bool isFirstDisplayedColumn, bool isFirstDisplayedRow) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object EditingCellFormattedValue { get{} set{} }
	public bool EditingCellValueChanged { get{} set{} }
	public Type EditType { get{} }
	public object FalseValue { get{} set{} }
	public FlatStyle FlatStyle { get{} set{} }
	public Type FormattedValueType { get{} }
	public object IndeterminateValue { get{} set{} }
	public bool ThreeState { get{} set{} }
	public object TrueValue { get{} set{} }
	public Type ValueType { get{} set{} }
	public AccessibleObject AccessibilityObject { get{} }
	public int ColumnIndex { get{} }
	public System.Drawing.Rectangle ContentBounds { get{} }
	public ContextMenuStrip ContextMenuStrip { get{} set{} }
	public object DefaultNewRowValue { get{} }
	public bool Displayed { get{} }
	public object EditedFormattedValue { get{} }
	public System.Drawing.Rectangle ErrorIconBounds { get{} }
	public string ErrorText { get{} set{} }
	public object FormattedValue { get{} }
	public bool Frozen { get{} }
	public bool HasStyle { get{} }
	public DataGridViewElementStates InheritedState { get{} }
	public DataGridViewCellStyle InheritedStyle { get{} }
	public bool IsInEditMode { get{} }
	public DataGridViewColumn OwningColumn { get{} }
	public DataGridViewRow OwningRow { get{} }
	public System.Drawing.Size PreferredSize { get{} }
	public bool ReadOnly { get{} set{} }
	public bool Resizable { get{} }
	public int RowIndex { get{} }
	public bool Selected { get{} set{} }
	public System.Drawing.Size Size { get{} }
	public DataGridViewCellStyle Style { get{} set{} }
	public object Tag { get{} set{} }
	public string ToolTipText { get{} set{} }
	public object Value { get{} set{} }
	public bool Visible { get{} }
	public DataGridViewElementStates State { get{} }
	public DataGridView DataGridView { get{} }
}

