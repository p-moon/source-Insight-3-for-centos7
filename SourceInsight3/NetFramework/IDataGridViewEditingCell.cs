public interface IDataGridViewEditingCell
{

	// Methods
	public abstract virtual object GetEditingCellFormattedValue(DataGridViewDataErrorContexts context) {}
	public abstract virtual void PrepareEditingCellForEdit(bool selectAll) {}

	// Properties
	public object EditingCellFormattedValue { get{} set{} }
	public bool EditingCellValueChanged { get{} set{} }
}

