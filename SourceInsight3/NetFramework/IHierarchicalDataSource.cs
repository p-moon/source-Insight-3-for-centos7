public interface IHierarchicalDataSource
{

	// Methods
	public abstract virtual HierarchicalDataSourceView GetHierarchicalView(string viewPath) {}

	// Events
	public event System.EventHandler DataSourceChanged;
}

