public interface IHierarchicalDataSourceDesigner
{

	// Methods
	public abstract virtual void Configure() {}
	public abstract virtual DesignerHierarchicalDataSourceView GetView(string viewPath) {}
	public abstract virtual void RefreshSchema(bool preferSilent) {}
	public abstract virtual void ResumeDataSourceEvents() {}
	public abstract virtual void SuppressDataSourceEvents() {}

	// Properties
	public bool CanConfigure { get{} }
	public bool CanRefreshSchema { get{} }

	// Events
	public event System.EventHandler DataSourceChanged;
	public event System.EventHandler SchemaRefreshed;
}

