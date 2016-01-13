public class TemplateColumn : DataGridColumn, System.Web.UI.IStateManager
{

	// Constructors
	public TemplateColumn() {}

	// Methods
	public virtual void InitializeCell(TableCell cell, int columnIndex, ListItemType itemType) {}
	public virtual void Initialize() {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Web.UI.ITemplate EditItemTemplate { get{} set{} }
	public System.Web.UI.ITemplate FooterTemplate { get{} set{} }
	public System.Web.UI.ITemplate HeaderTemplate { get{} set{} }
	public System.Web.UI.ITemplate ItemTemplate { get{} set{} }
	public TableItemStyle FooterStyle { get{} }
	public string FooterText { get{} set{} }
	public string HeaderImageUrl { get{} set{} }
	public TableItemStyle HeaderStyle { get{} }
	public string HeaderText { get{} set{} }
	public TableItemStyle ItemStyle { get{} }
	public string SortExpression { get{} set{} }
	public bool Visible { get{} set{} }
}

