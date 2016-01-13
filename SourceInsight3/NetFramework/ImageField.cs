public class ImageField : DataControlField, System.Web.UI.IStateManager, System.Web.UI.IDataSourceViewSchemaAccessor
{

	// Constructors
	public ImageField() {}

	// Methods
	public virtual void ExtractValuesFromCell(System.Collections.Specialized.IOrderedDictionary dictionary, DataControlFieldCell cell, DataControlRowState rowState, bool includeReadOnly) {}
	public virtual bool Initialize(bool enableSorting, System.Web.UI.Control control) {}
	public virtual void InitializeCell(DataControlFieldCell cell, DataControlCellType cellType, DataControlRowState rowState, int rowIndex) {}
	public virtual void ValidateSupportsCallback() {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string ThisExpression;

	// Properties
	public string AlternateText { get{} set{} }
	public bool ConvertEmptyStringToNull { get{} set{} }
	public string DataAlternateTextField { get{} set{} }
	public string DataAlternateTextFormatString { get{} set{} }
	public string DataImageUrlField { get{} set{} }
	public string DataImageUrlFormatString { get{} set{} }
	public string NullDisplayText { get{} set{} }
	public string NullImageUrl { get{} set{} }
	public bool ReadOnly { get{} set{} }
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

