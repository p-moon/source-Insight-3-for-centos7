public class DesignerDataSourceView
{

	// Methods
	public virtual System.Collections.IEnumerable GetDesignTimeData(int minimumRowsout , System.Boolean& isSampleData) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool CanDelete { get{} }
	public bool CanInsert { get{} }
	public bool CanPage { get{} }
	public bool CanRetrieveTotalRowCount { get{} }
	public bool CanSort { get{} }
	public bool CanUpdate { get{} }
	public IDataSourceDesigner DataSourceDesigner { get{} }
	public string Name { get{} }
	public IDataSourceViewSchema Schema { get{} }
}

