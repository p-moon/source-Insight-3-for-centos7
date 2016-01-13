public class TemplateField : DataControlField, System.Web.UI.IStateManager, System.Web.UI.IDataSourceViewSchemaAccessor
{

	// Constructors
	public TemplateField() {}

	// Methods
	public virtual void ExtractValuesFromCell(System.Collections.Specialized.IOrderedDictionary dictionary, DataControlFieldCell cell, DataControlRowState rowState, bool includeReadOnly) {}
	public virtual void InitializeCell(DataControlFieldCell cell, DataControlCellType cellType, DataControlRowState rowState, int rowIndex) {}
	public virtual void ValidateSupportsCallback() {}
	public virtual bool Initialize(bool sortingEnabled, System.Web.UI.Control control) {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Web.UI.ITemplate AlternatingItemTemplate { get{} set{} }
	public bool ConvertEmptyStringToNull { get{} set{} }
	public System.Web.UI.ITemplate EditItemTemplate { get{} set{} }
	public System.Web.UI.ITemplate FooterTemplate { get{} set{} }
	public System.Web.UI.ITemplate HeaderTemplate { get{} set{} }
	public System.Web.UI.ITemplate InsertItemTemplate { get{} set{} }
	public System.Web.UI.ITemplate ItemTemplate { get{} set{} }
	public string AccessibleHeaderText { get{} set{} }
	public Style ControlStyle { get{} }
	public TableItemStyle FooterStyle { get{} }
	public string FooterText { get{} set{} }
	public string HeaderImageUrl { get{} set{} }
	public TableItemStyle HeaderStyle { get{} }
	public string HeaderText { get{} set{} }
	public bool InsertVisible { get{} set{} }
	public TableItemStyle ItemStyle { get{} }
	public bool ShowHeader { get{} set{} }
	public string SortExpression { get{} set{} }
	public bool Visible { get{} set{} }
}

