public class BoundColumn : DataGridColumn, System.Web.UI.IStateManager
{

	// Constructors
	public BoundColumn() {}

	// Methods
	public virtual void Initialize() {}
	public virtual void InitializeCell(TableCell cell, int columnIndex, ListItemType itemType) {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string thisExpr;

	// Properties
	public string DataField { get{} set{} }
	public string DataFormatString { get{} set{} }
	public bool ReadOnly { get{} set{} }
	public TableItemStyle FooterStyle { get{} }
	public string FooterText { get{} set{} }
	public string HeaderImageUrl { get{} set{} }
	public TableItemStyle HeaderStyle { get{} }
	public string HeaderText { get{} set{} }
	public TableItemStyle ItemStyle { get{} }
	public string SortExpression { get{} set{} }
	public bool Visible { get{} set{} }
}

