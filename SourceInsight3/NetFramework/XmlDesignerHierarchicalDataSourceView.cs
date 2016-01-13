public class XmlDesignerHierarchicalDataSourceView : System.Web.UI.Design.DesignerHierarchicalDataSourceView
{

	// Constructors
	public XmlDesignerHierarchicalDataSourceView(XmlDataSourceDesigner owner, string viewPath) {}

	// Methods
	public virtual System.Web.UI.IHierarchicalEnumerable GetDesignTimeData(out System.Boolean& isSampleData) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Web.UI.Design.IDataSourceSchema Schema { get{} }
	public System.Web.UI.Design.IHierarchicalDataSourceDesigner DataSourceDesigner { get{} }
	public string Path { get{} }
}

