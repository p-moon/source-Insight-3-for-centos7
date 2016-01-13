public class DesignerHierarchicalDataSourceView
{

	// Methods
	public virtual System.Web.UI.IHierarchicalEnumerable GetDesignTimeData(out System.Boolean& isSampleData) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public IHierarchicalDataSourceDesigner DataSourceDesigner { get{} }
	public string Path { get{} }
	public IDataSourceSchema Schema { get{} }
}

