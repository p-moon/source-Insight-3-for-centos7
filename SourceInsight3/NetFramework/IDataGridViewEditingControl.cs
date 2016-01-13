public interface IDataGridViewEditingControl
{

	// Methods
	public abstract virtual void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle) {}
	public abstract virtual bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey) {}
	public abstract virtual object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context) {}
	public abstract virtual void PrepareEditingControlForEdit(bool selectAll) {}

	// Properties
	public DataGridView EditingControlDataGridView { get{} set{} }
	public object EditingControlFormattedValue { get{} set{} }
	public int EditingControlRowIndex { get{} set{} }
	public bool EditingControlValueChanged { get{} set{} }
	public Cursor EditingPanelCursor { get{} }
	public bool RepositionEditingControlOnValueChange { get{} }
}

