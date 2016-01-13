public class EditCommandColumn : DataGridColumn, System.Web.UI.IStateManager
{

	// Constructors
	public EditCommandColumn() {}

	// Methods
	public virtual void InitializeCell(TableCell cell, int columnIndex, ListItemType itemType) {}
	public virtual void Initialize() {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ButtonColumnType ButtonType { get{} set{} }
	public string CancelText { get{} set{} }
	public bool CausesValidation { get{} set{} }
	public string EditText { get{} set{} }
	public string UpdateText { get{} set{} }
	public string ValidationGroup { get{} set{} }
	public TableItemStyle FooterStyle { get{} }
	public string FooterText { get{} set{} }
	public string HeaderImageUrl { get{} set{} }
	public TableItemStyle HeaderStyle { get{} }
	public string HeaderText { get{} set{} }
	public TableItemStyle ItemStyle { get{} }
	public string SortExpression { get{} set{} }
	public bool Visible { get{} set{} }
}

