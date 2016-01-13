public class CommandField : ButtonFieldBase, System.Web.UI.IStateManager, System.Web.UI.IDataSourceViewSchemaAccessor
{

	// Constructors
	public CommandField() {}

	// Methods
	public virtual void InitializeCell(DataControlFieldCell cell, DataControlCellType cellType, DataControlRowState rowState, int rowIndex) {}
	public virtual void ValidateSupportsCallback() {}
	public virtual void ExtractValuesFromCell(System.Collections.Specialized.IOrderedDictionary dictionary, DataControlFieldCell cell, DataControlRowState rowState, bool includeReadOnly) {}
	public virtual bool Initialize(bool sortingEnabled, System.Web.UI.Control control) {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string CancelImageUrl { get{} set{} }
	public string CancelText { get{} set{} }
	public bool CausesValidation { get{} set{} }
	public string DeleteImageUrl { get{} set{} }
	public string DeleteText { get{} set{} }
	public string EditImageUrl { get{} set{} }
	public string EditText { get{} set{} }
	public string InsertImageUrl { get{} set{} }
	public string InsertText { get{} set{} }
	public string NewImageUrl { get{} set{} }
	public string NewText { get{} set{} }
	public string SelectImageUrl { get{} set{} }
	public string SelectText { get{} set{} }
	public bool ShowCancelButton { get{} set{} }
	public bool ShowDeleteButton { get{} set{} }
	public bool ShowEditButton { get{} set{} }
	public bool ShowSelectButton { get{} set{} }
	public bool ShowInsertButton { get{} set{} }
	public string UpdateImageUrl { get{} set{} }
	public string UpdateText { get{} set{} }
	public ButtonType ButtonType { get{} set{} }
	public bool ShowHeader { get{} set{} }
	public string ValidationGroup { get{} set{} }
	public string AccessibleHeaderText { get{} set{} }
	public Style ControlStyle { get{} }
	public TableItemStyle FooterStyle { get{} }
	public string FooterText { get{} set{} }
	public string HeaderImageUrl { get{} set{} }
	public TableItemStyle HeaderStyle { get{} }
	public string HeaderText { get{} set{} }
	public bool InsertVisible { get{} set{} }
	public TableItemStyle ItemStyle { get{} }
	public string SortExpression { get{} set{} }
	public bool Visible { get{} set{} }
}

