public class XmlDesignerDataSourceView : System.Web.UI.Design.DesignerDataSourceView
{

	// Constructors
	public XmlDesignerDataSourceView(XmlDataSourceDesigner owner, string viewName) {}

	// Methods
	public virtual System.Collections.IEnumerable GetDesignTimeData(int minimumRowsout , System.Boolean& isSampleData) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Web.UI.Design.IDataSourceViewSchema Schema { get{} }
	public bool CanDelete { get{} }
	public bool CanInsert { get{} }
	public bool CanPage { get{} }
	public bool CanRetrieveTotalRowCount { get{} }
	public bool CanSort { get{} }
	public bool CanUpdate { get{} }
	public System.Web.UI.Design.IDataSourceDesigner DataSourceDesigner { get{} }
	public string Name { get{} }
}

